using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vince.SiteUI.Models
{
    public class VinceViewModel
    {
        public string Name
        { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public List<string> CurrentSkills { get; set; }

        public List<string> UpcomingSkills { get; set; }

        
        public string SecondaryEmail { get; set; }
    }
}