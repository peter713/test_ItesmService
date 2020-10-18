using System;
using System.Collections.Generic;
using System.Text;


namespace test_ItesmService
{
    public class ItemService
    {
        public List<Item> Items { get; set; }

        public List<Item> GetAllItems()
        {
            return Items;
        }

        public int AddNewItem()
        {
            Item item = new Item() { Id = 1, Name = "Apple" };
            Items.Add(item);
            return item.Id;
        }


    }
}
