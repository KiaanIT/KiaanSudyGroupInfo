using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaanSudyGroupInfo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult MyIndex()
        {

            List<Models.MyClass> Support = new List<Models.MyClass>();

            Support.Add(new Models.MyClass { StudentNumber = "u24600904", Name = "Kiaan", Surname = "Taljaard", Email = "u24600904@tuks.co.za", myLink = Url.Content("~/HTML/Kiaan.html") });
            Support.Add(new Models.MyClass { StudentNumber = "u24943802", Name = "Danel", Surname = "Steyn", Email = "u24943802@tuks.co.za", myLink = Url.Content("~/HTML/Danel.html") });
            Support.Add(new Models.MyClass { StudentNumber = "u24589412", Name = "Arno", Surname = "Redpath", Email = "u24589412@tuks.co.za" , myLink = Url.Content("~/HTML/Arno.html") });
            Support.Add(new Models.MyClass { StudentNumber = "u24569748", Name = "Milos", Surname = "Sarovic", Email = "u24569748@tuks.co.za", myLink = Url.Content("~/HTML/Milos.html") });
            Support.Add(new Models.MyClass { StudentNumber = "u23815524", Name = "Sechaba", Surname = "Phahlamohlaka", Email = "u23815524@tuks.co.za" , myLink = Url.Content("~/HTML/Sechaba.html") });
            

            return View(Support);
        }
    }
}