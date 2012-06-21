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
        public string Body { get; set; }
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