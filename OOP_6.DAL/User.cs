using System.Diagnostics.Contracts;

namespace OOP_6.DAL
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime BirthDate { get; set; }

        public User(string firstName, string lastName, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
        }
    }
}