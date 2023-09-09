using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Configurations.Filters
{
    public class MyFilter : IActionFilter
    {
        // Imp Note:OnActionExecuting comes first in the picture, then comes OnActionExecuted()
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Executing MyFilter: OnActionExecuting");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Executing MyFilter: OnActionExecuted");
        }

    }
}
