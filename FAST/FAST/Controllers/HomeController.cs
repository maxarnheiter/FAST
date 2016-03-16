using FAST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAST.Controllers
{
    public class HomeController : Controller
    {

        private ContactDBContext contactDB = new ContactDBContext();
        private CompaniesDBContext companiesDB = new CompaniesDBContext();
        private GroupsDBContext groupsDB = new GroupsDBContext();

        public ActionResult Index()
        {
            ViewBag.ContactsCount = contactDB.Contacts.Count();
            ViewBag.CompaniesCount = companiesDB.Companies.Count();
            ViewBag.GroupsCount = groupsDB.Groups.Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}