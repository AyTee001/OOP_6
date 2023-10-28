using Bogus;
using Microsoft.EntityFrameworkCore;

namespace OOP_6.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        private static readonly int _userSeed = 1234;
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(GetUsers());
        }

        private static ICollection<User> GetUsers(int count = 70)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<User>()
                .CustomInstantiator(f => new User(f.Name.FirstName(), f.Name.LastName(), f.Internet.Email(), f.Address.FullAddress()))
                .UseSeed(_userSeed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.BirthDate, f => f.Date.Between(new DateTime(1980, 9, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2008, 9, 22, 0, 0, 0, DateTimeKind.Utc)))
                .RuleFor(e => e.RegisteredAt, (f, e) => f.Date.Between(e.BirthDate, new DateTime(2023, 9, 22, 0, 0, 0, DateTimeKind.Utc)))
                .Generate(count)
                .ToList();
        }
    }
}
