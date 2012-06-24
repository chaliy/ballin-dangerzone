using System.Collections.Generic;
using System.Web.Http;

namespace WebApp.Api
{      
    public class ItemsController : ApiController
    {
        // GET api/<controller>
        public ItemsModel Get()
        {
            return ItemsStorage.Instance;
        }

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/items/mail/        
        [ActionName("mail")]
        public void PostMail(MailItemCandidate candidate)
        {
            // You can find code
            // candidate.Subject ?? "",
            // strange, this is know issue of template compilation stuff
            // it require field in json, however Json.NET does not render strings fields
            // if they are null. Of course I will never put such code to production

            ItemsStorage.Instance.Items.Add(new MailItem
            {
                Subject = candidate.Subject ?? "",
                From = candidate.To ?? "",
                Body = candidate.Body ?? "",
                Folder = candidate.Folder ?? ""
            });
        }

        // POST api/items/contact/                
        [ActionName("contact")]
        public void PostContact(ContactItemCandidate candidate)
        {
            ItemsStorage.Instance.Items.Add(new ContactItem
            {
                FirstName = candidate.FirstName ?? "",
                LastName = candidate.LastName ?? "",
                Phone = candidate.Phone ?? "",
                Email = candidate.Email ?? "",
                PhotoUrl = candidate.PhotoUrl ?? "",
                Folder = candidate.Folder ?? ""
            });
        }

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