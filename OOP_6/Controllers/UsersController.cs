using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OOP_6.Exceptions;
using OOP_6.Interfaces;
using OOP_6.Models;
using OOP_6.Models.DTO;

namespace OOP_6.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_userService.GetUsers());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new FormWithResultModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(FormWithResultModel form)
        {
            if (ModelState.IsValid)
            {
                form.UserToForm = await _userService.CreateUserAsync(form.UserFromForm);
            }

            return View("Add", form);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var user = _userService.GetUsers().FirstOrDefault(x => x.Id == id);

            return user == null
                ? throw new NotFoundException(nameof(id))
                : (IActionResult)View(_mapper.Map<UserUpdateDto>(user));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateDto user)
        {
            if (ModelState.IsValid)
            {
                await _userService.UpdateUserAsync(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UserUpdateDto user)
        {
            await _userService.DeleteUserByIdAsync(user.Id);

            return RedirectToAction("Index");
        }
    }
}