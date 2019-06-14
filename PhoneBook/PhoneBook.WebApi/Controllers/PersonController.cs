using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PhoneBook.WebApi.Controllers
{
    public class PersonController:ApiController
    {
        RepositoryPattern<Person> repo = new RepositoryPattern<Person>();
       
        /// <summary>
        /// Kişi Listesini Getirir. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Person> GetPersons()
        {
            var result = repo.List();
            return result;
        }

        /// <summary>
        /// Kişi detayı getirir.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public Person _GetPerson(int Id)
        {          
            var result = repo.Find(x=>x.ID==Id);
            return result;
        }

        /// <summary>
        /// Kişi Ekler.
        /// </summary>
        /// <param name="person"></param>
        [HttpPost]
        public void AddPerson(Person person)
        {
           repo.Add(person);
        }
    }
}