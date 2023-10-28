using OOP_6.DAL;
using OOP_6.Models.DTO;

namespace OOP_6.Models
{
    public class FormWithResultModel
    {
        public UserDto UserFromForm { get; set; } = new();
        public User? UserToForm { get; set; }
    }
}
