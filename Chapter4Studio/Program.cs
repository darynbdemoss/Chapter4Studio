using System;
using System.Collections.Generic;

namespace Chapter4Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItems steak = new MenuItems(16.57, "Filet Mignon", "Dinner", true);
            MenuItems pasta = new MenuItems(9.99, "Shrimp Pasta", "Lunch", true);
            MenuItems waffles = new MenuItems(7.64, "Blue Berry PanCakes", "Breaky", true);

            DateTime today = DateTime.Now;

            List<MenuItems> itemsList = new List<MenuItems> { steak, pasta, waffles };

            Menu theMenu = new Menu(today, itemsList);

            theMenu.Print();

        }
    }
}
