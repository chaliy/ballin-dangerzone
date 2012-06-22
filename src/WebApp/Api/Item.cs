using System.Collections.Generic;

namespace WebApp.Api
{
    public abstract class Item
    {
        public string Folder { get; set; }        
    }

    public class MailItem : Item
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
    }

    public class ContactItem : Item
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
    }

    public class ItemsModel
    {
        public List<Item> Items { get; set; }

        public ItemsModel()
        {
            Items = new List<Item>();
        }
    }
}