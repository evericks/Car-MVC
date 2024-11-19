using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class BaseController : Controller
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var username = context.HttpContext.Session.GetString("LoggedInUser");
        ViewBag.IsLoggedIn = !string.IsNullOrEmpty(username);
        ViewBag.Username = username;

        base.OnActionExecuting(context);
    }
}