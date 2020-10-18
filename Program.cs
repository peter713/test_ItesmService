using System;
using System.Collections.Generic;

namespace test_ItesmService
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemService itemService = new ItemService();
           
            itemService.AddNewItem();

            List<Item> result = itemService.GetAllItems();

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
