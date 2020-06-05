using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4Studio
{
    class MenuItems
    {       
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItems(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }
}
