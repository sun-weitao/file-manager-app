using file_manager_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace file_manager_app.Controllers
{
    public class FileController : Controller
    {
        private FileManagerDB fmb = new FileManagerDB();
        // GET: File
        public ActionResult Index()
        {
            using (DataModelContainer db = new DataModelContainer()) {
                
            }
            return View();
        }

        public ActionResult UploadFile(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View("add");
        }

        [HttpPost]
        public async Task<ActionResult> add(FileViewModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string url = "/Content/FileManager/"+model.file.FileName;
                string savePath = AppDomain.CurrentDomain.BaseDirectory + url;
                System.Diagnostics.Debug.WriteLine("dir   " + AppDomain.CurrentDomain.BaseDirectory);
                model.file.SaveAs(savePath);
                using (DataModelContainer db = new DataModelContainer())
                {
                    User user = (User)Session["user"]; 
                    File file = new File() {
                        User_id = user.id,
                        title = model.title,
                        url = url,
                        createtime = new DateTime(),
                        isshared = model.isShared == 1
                    };
                  
                    db.File.Add(file);
                    db.SaveChanges();
                }
            }
            return View(model);
        }
    }
}