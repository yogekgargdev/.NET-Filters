using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Configurations.Filters
{
    public class MySecondActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Executing MySecondActionFilterAttribute: Start");
            await next();
            Console.WriteLine($"Executing MySecondActionFilterAttribute: End");
        }
    }
}
