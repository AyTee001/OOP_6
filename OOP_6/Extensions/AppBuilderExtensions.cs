using Microsoft.EntityFrameworkCore;
using OOP_6.DAL.Context;

namespace OOP_6.Extensions
{
    public static class AppBuilderExtensions
    {
        public static void UseUserAppContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<UserAppContext>();

            context?.Database.Migrate();
        }
    }
}
