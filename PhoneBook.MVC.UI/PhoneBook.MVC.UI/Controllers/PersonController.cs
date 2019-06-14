using PhoneBook.MVC.UI.Entities;
using PhoneBook.MVC.UI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.MVC.UI.Controllers
{
    public class PersonController : Controller
    {

        public ActionResult Index()
        {        
            return View();
        }
        public ActionResult GetPersons()
        {
            List<Person> person = new List<Person>();
            person = HTTPHelper.GetList<List<Person>>("http://localhost:53006/", "Person/GetPersons", Method.GET);
            return View(person);
        }

        public ActionResult GetPersonDetail(int id)
        {
            Person person = new Person();
            PersonModel model = new PersonModel();
            List<Phone> phones = new List<Phone>();
            phones = HTTPHelper.GetList<List<Phone>>("http://localhost:53006/", "Phone/GetPhone",Method.GET, id);
            person = HTTPHelper.GetDetail<Person>("http://localhost:53006/", "Person/_GetPerson",Method.GET, id);

            model.Phones = phones;
            model.Person = person;
            
            return View(model);
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(Person person)
        {
            HTTPHelper.Add<Person>("http://localhost:53006/", "Person/AddPerson",person ,Method.POST);
            return RedirectToAction("GetPersons");
        }
    }
}