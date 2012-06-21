using System.Collections.Generic;
using System.Web.Http;

namespace WebApp.Api
{

   
    
    public class ItemsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Item> Get()
        {
            return new []
            {
                new Item { Subject = "Foo#1", Body = "Foo#1"},
                new Item { Subject = "Foo#2", Body = "Foo#2"}
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