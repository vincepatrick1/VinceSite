using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vince.SiteUI.Models;

namespace Vince.SiteUI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ViewResult Index()
        {
            VinceViewModel v = new VinceViewModel();
            v.Email = "richard.patrick@louisville.edu";
            v.Phone = "502-792-4984";
            v.SecondaryEmail = "vince.patrick225@gmail.com";
            return View(v);
        }
    }
}