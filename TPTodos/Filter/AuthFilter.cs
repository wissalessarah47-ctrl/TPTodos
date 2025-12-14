using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace TPTodos.Filter
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string role = context.HttpContext.Session.GetString("role");

            if (string.IsNullOrEmpty(role))
            {
                context.Result = new RedirectResult("/users/login");
            }

            base.OnActionExecuting(context);
        }
    }