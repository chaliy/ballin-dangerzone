using System.Collections.Generic;
using System.Web.Http;

namespace WebApp.Api
{
      
    public class ItemsController : ApiController
    {
        // GET api/<controller>
        public ItemsModel Get()
        {
            return new ItemsModel
            {
                Items = new List<Item>
                {
                    new MailItem { Folder = "mail.copmany", Subject = "Foo#1", Body = "Foo#1" },
                    new MailItem { Folder = "mail.copmany", Subject = "Foo#2", Body = "Foo#2"}
                }
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post(string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}