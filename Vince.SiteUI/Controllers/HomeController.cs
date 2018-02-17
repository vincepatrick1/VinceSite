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
        public ViewResult Index()
        {
            VinceViewModel vince = new VinceViewModel();
            currentSkills.Add("C#");
            currentSkills.Add("SQL");
            currentSkills.Add("Javascript");
            currentSkills.Add("HTML/CSS");
            currentSkills.Add("ASP.NET Web Forms");
            currentSkills.Add("ASP.NET MVC 5");
            currentSkills.Add("jQuery");
            currentSkills.Add("Angular");
            upcomingSkills.Add("Python");


            vince.CurrentSkills = currentSkills;
            vince.UpcomingSkills = upcomingSkills;
            return View(vince);
            
        }
    }
}