using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogInApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.VisualBasic.ApplicationServices;

namespace LogInApp.Controllers
{
    public class AdminPageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AdminPage
        public ActionResult Index(string id)
        
        {
            if (id != null)
            {
                string roleId = 2.ToString();
                ApplicationUser aApplicaionUser = db.Users.FirstOrDefault(m => m.Id == id);
                aApplicaionUser.IsActive = true;
                db.Entry(aApplicaionUser).State = EntityState.Modified;
                db.SaveChanges();
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);                                
             
               // ApplicationUserManager userManager=new ApplicationUserManager();
                userManager.AddToRole(id, "Doctor");
            }
            List<ApplicationUser> inActiveUserList = db.Users.Where(m => m.IsActive == false).ToList();
            return View(inActiveUserList);
        }


    }
}