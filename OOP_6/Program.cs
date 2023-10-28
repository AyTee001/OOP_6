using Microsoft.EntityFrameworkCore;
using OOP_6.DAL.Context;
using OOP_6.Extensions;
using OOP_6.Interfaces;
using OOP_6.Services;

namespace OOP_6
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddDbContext<UserAppContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("UserAppContextConnection"),
                    opt => opt.MigrationsAssembly(typeof(UserAppContext).Assembly.GetName().Name)));

            var app = builder.Build();

            app.UseUserAppContext();


            if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Users}/{action=Index}");

            app.Run();
        }
    }
}