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
                    new MailItem { Folder = "mail.company", Subject = "Foo#1", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae arcu dolor, sagittis commodo mi. Sed venenatis lorem non mi rutrum tempus. Fusce dolor diam, convallis at pharetra eget, aliquet sed diam. Etiam at urna elit. Vestibulum id iaculis ante. Sed nec arcu lacus, eu interdum mi.", From = "a1@example.com" },
                    new MailItem { Folder = "mail.company", Subject = "Foo#2", Body = "Nullam gravida cursus massa, vel ultricies nibh elementum nec. Vestibulum consectetur luctus cursus. Donec gravida laoreet ultrices. Morbi ut quam vitae nunc posuere dignissim sit amet nec lacus.", From = "a2@example.com" },
                    new MailItem { Folder = "mail.personal", Subject = "Foo#3", Body = "Donec mauris tellus, eleifend sed convallis sit amet, fermentum non est. Pellentesque volutpat blandit turpis, ac interdum nisl euismod vitae. Nam luctus luctus purus, eu adipiscing mauris sagittis non.", From = "Bill Gates" },
                    new MailItem { Folder = "mail.inner", Subject = "Foo#4", Body = "Etiam venenatis tincidunt lectus, ac egestas ante sagittis vel.", From = "" },
                    new MailItem { Folder = "mail.personal", Subject = "Foo#5", Body = "Suspendisse potenti. Donec accumsan commodo tortor, eget pellentesque mauris fringilla ac.", From = "" },
                    new ContactItem { Folder = "contact.company", FirstName = "Mike", LastName = "Chaliy", Email = "mike@chaliy.name", Phone = "+380971918198", PhotoUrl = "http://chaliy.name/images/avatar320.jpg"},
                }
            };
        }

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post(string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}