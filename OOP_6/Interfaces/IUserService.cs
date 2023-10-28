using OOP_6.DAL;
using OOP_6.Models.DTO;

namespace OOP_6.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(UserDto userCreateDto);
        ICollection<User> GetUsers();
        User GetUserById(long id);
        Task DeleteUserByIdAsync(long id);
        Task<User> UpdateUserAsync(UserUpdateDto userDto);
    }
}
