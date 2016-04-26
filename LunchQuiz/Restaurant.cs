using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Restaurant
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<Customer> CurrentCustomers { get; set; }

        public int NumberofSeatsAtBar { get; set; }
        public int Numberof4PersonTables { get; set; }
        public int Numberof2PersonTables { get; set; }

        public int capacity()
        {
            return NumberofSeatsAtBar + Numberof4PersonTables + Numberof2PersonTables;
        }

        public void addMenuItem(string newMenuItem)
        {
            this.MenuItems.Add(new MenuItem() {
                Name = newMenuItem
            });
        }
        public void addMenuItem(string newMenuItem, double Price)
        {
            this.MenuItems.Add(new MenuItem()
            {
                Name = newMenuItem,
                Price = Price 
            });
        }
        public void AddCustomerToList(Customer customer)
        {

        }
        public bool ItemIsOnMenu(string menuItem)
        {
            if (this.MenuItems.Contains(new MenuItem { Name = menuItem } ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ItemIsOnMenu(MenuItem menuItem)
        {
            if (this.MenuItems.Contains(menuItem))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Restaurant()
        {
            this.MenuItems = new List<MenuItem>();
        }
    }
}
