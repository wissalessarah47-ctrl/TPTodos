namespace TPTodos.Filter
{
public class ThemeFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var theme = context.HttpContext.Request.Cookies["theme"] ?? "light";
            
            if (context.Controller is Controller controller)
            {
                controller.ViewData["Theme"] = theme;
            }
            
            base.OnActionExecuting(context);
        }
    }
