using System;
using System.Web;
using System.Web.Mvc;

namespace QA
{
    public class FilterConfig : FilterAttribute, IActionFilter
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["user"] == null)
            { filterContext.HttpContext.Response.Write(-1); }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["user"] == null)
            {
                try
                {
                    filterContext.Result = new RedirectResult("/Account/Login");
                }
                catch (Exception)
                {

                    filterContext.Result = new RedirectResult("/Wrong/Login");
                }
            }
        }
    }
}