using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Configurations.Filters
{
    public class MyAsyncActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Executing MyAsyncActionFilterAttribute: Start");
            await next();
            Console.WriteLine($"Executing MyAsyncActionFilterAttribute: End");
        }
    }
}
