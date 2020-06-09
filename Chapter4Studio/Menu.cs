using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4Studio
{
    public class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItems> Items { get; set; }
        

        public Menu(DateTime dateUpdated, List<MenuItems> item)
        {
            LastUpdated = dateUpdated;
            Items = item;
            
        }
         public List<MenuItems> AddItem(MenuItems item)
        {
            Items.Add(item);
            LastUpdated = DateTime.Now;

            return Items;
        }

        public List<MenuItems> RemoveItem(MenuItems item)
        {
            Items.Remove(item);

            return Items;
        }

        public string MenuLastUpdated()
        {
            return $"The menu was last updated on {LastUpdated}";
        }

        public void Print()
        {
            Console.WriteLine("\n\n******* OUR MENU ******");

            foreach (MenuItems item in Items)
            {
                item.Print();
            }

            Console.WriteLine("***************\n\n");
        }

    }
}
