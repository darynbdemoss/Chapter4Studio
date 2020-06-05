using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4Studio
{
    public class Menu
    {      

        public List<MenuItems> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(List<MenuItems> items, DateTime lastUpdated)
        {
            Items = items;
            LastUpdated = lastUpdated;
        }


    }
}
