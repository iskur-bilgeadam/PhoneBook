using PhoneBook.MVC.UI.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.MVC.UI.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPhone(int id)
        {
            List<Phone> phones = new List<Phone>();
            phones = HTTPHelper.GetList<List<Phone>>("http://localhost:53006/", "Phone/GetPhone", Method.GET,id);
            return View(phones);
        }
        public ActionResult AddPhone()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult AddPhone(Phone phone,int id)
        {
            phone.PersonID = id;

            HTTPHelper.Add<Phone>("http://localhost:53006/", "Phone/AddPhone", phone, Method.POST);
            return RedirectToAction("GetPersons","Person");
        }
    }
}