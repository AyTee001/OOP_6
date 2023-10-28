using AutoMapper;
using OOP_6.DAL;
using OOP_6.DAL.Context;
using OOP_6.Exceptions;
using OOP_6.Interfaces;
using OOP_6.Models.DTO;

namespace OOP_6.Services
{
    public class UserService : IUserService
    {
        private protected readonly UserAppContext _context;
        private protected readonly IMapper _mapper;
        public UserService(UserAppContext context, IMapper mapper) 
        {
            _context = context;  
            _mapper = mapper;
        }

        public async Task<User> CreateUserAsync(UserDto userCreateDto)
        {
            var newUser = _mapper.Map<User>(userCreateDto);

            _context.Users.Add(newUser);

            await _context.SaveChangesAsync();

            return newUser;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(long id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id) ?? throw new NotFoundException(nameof(User));
        }

        public async Task DeleteUserByIdAsync(long id)
        {
            var userToRemove = _context.Users.SingleOrDefault(x => x.Id == id);

            _context.Remove(userToRemove ?? throw new NotFoundException(nameof(User)));

            await _context.SaveChangesAsync();
        }

        public async Task<User> UpdateUserAsync(UserUpdateDto userDto)
        {
            var userToUpdate = _context.Users.SingleOrDefault(x => x.Id == userDto.Id) ?? throw new NotFoundException(nameof(User));

            _mapper.Map(userDto, userToUpdate);

            await _context.SaveChangesAsync();

            return userToUpdate;
        }
    }
}
