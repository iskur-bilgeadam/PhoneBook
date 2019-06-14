using PhoneBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PhoneBook.WebApi.Controllers
{
    public class PhoneTypeController:ApiController
    {
        RepositoryPattern<PhoneType> repo = new RepositoryPattern<PhoneType>();

        [HttpGet]
        public List<PhoneType> GetType()
        {
            return repo.List();
        }
    }
}