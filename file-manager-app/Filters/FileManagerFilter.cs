using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace file_manager_app.Filters
{
    public class FileManagerFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            var user = filterContext.HttpContext.Session["user"];
            string constrollerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            System.Diagnostics.Debug.WriteLine(constrollerName + "/" + actionName);

            if (user == null && (constrollerName+"/"+actionName).ToLower() != "login/index")
            {
                filterContext.Result = new RedirectResult("/login/index");
            }
            base.OnActionExecuted(filterContext);
        }

    }
    

}