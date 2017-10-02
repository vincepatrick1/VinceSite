using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vince.SiteUI.Models;

namespace Vince.SiteUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public List<string> currentSkills = new List<string>();
        public List<string> upcomingSkills = new List<string>();
        public ViewResult Home()
        {
            VinceViewModel vince = new VinceViewModel();
            currentSkills.Add("C#");
            currentSkills.Add("SQL");
            currentSkills.Add("Javascript");
            currentSkills.Add("HTML/CSS");
            currentSkills.Add("ASP.NET Web Forms");
            upcomingSkills.Add("ASP.NET MVC 5");
            upcomingSkills.Add("Python");
            upcomingSkills.Add("jQuery");
            //upcomingSkills.Add("Angular");

            vince.CurrentSkills = currentSkills;
            vince.UpcomingSkills = upcomingSkills;
            return View(vince);
            
        }
    }
}