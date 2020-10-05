using file_manager_app.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace file_manager_app.Controllers
{
   
    public class LoginController : Controller
    {
        private DataModelContainer db = new DataModelContainer();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult doLogin([Bind(Include = "username,password")] User user)
        {
            //System.Diagnostics.Debug.WriteLine(user.username);
            //Console.WriteLine(user);
            using (DataModelContainer db = new DataModelContainer())
            {
                DbQuery<User> dbQuery = db.User.Where(u => u.username == user.username && u.password == user.password).Take(1) as DbQuery<User>;
                User users = dbQuery.FirstOrDefault();
                if(users != null)
                {
                    Session["user"] = users;
                    return RedirectToAction("Index","Home");
                }
            } 
            return RedirectToAction("Index","Login");
        }
    }
}