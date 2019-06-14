using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PhoneBook.WebApi.Controllers
{
    public class PhoneController:ApiController
    {
        RepositoryPattern<Phone> repo = new RepositoryPattern<Phone>();
        RepositoryPattern<Person> repo1 = new RepositoryPattern<Person>();

        /// <summary>
        /// Kişiye ait telefonları getirir.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Phone> GetPhone(int Id)
        {
            var result= repo.List(x => x.PersonID == Id);
            return result;
        }

        /// <summary>
        /// Kişiye özel telefon ekler.
        /// </summary>
        /// <param name="phone"></param>
        public void AddPhone(Phone phone)
        {
            Phone phones = new Phone();        
            phones.PersonID = phone.PersonID;
            phones.PhoneNumber = phone.PhoneNumber;
            phones.TypeID = phone.TypeID;
            repo.Add(phones);
        }
    }
}