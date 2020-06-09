using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4Studio
{
    public class MenuItems
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

        public void Print()
        {
            Console.WriteLine(Category + " : " + Description + " : " + Price + "$");
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            MenuItems itemObj = obj as MenuItems;
            return Description == itemObj.Description;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
