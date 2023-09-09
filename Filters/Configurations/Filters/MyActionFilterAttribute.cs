using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Configurations.Filters
{
    public class MyActionFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Executing MyActionFilterAttribute: OnActionExecuting");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Executing MyActionFilterAttribute: OnActionExecuted");
        } 
    }
}
