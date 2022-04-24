using Microsoft.AspNetCore.Builder;
using WebApplication.Middlewares;

namespace WebApplication.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
