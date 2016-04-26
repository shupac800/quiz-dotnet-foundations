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

        }
        public void addMenuItem(string newMenuItem, double Price)
        {

        }
        public void AddCustomerToList(Customer customer)
        {

        }
        public bool ItemIsOnMenu(string menuItem)
        {
            return true;
        }
        public bool ItemIsOnMenu(MenuItem menuItem)
        {
            return true;
        }

        public Restaurant()
        {
            this.MenuItems = new List<MenuItem>();
        }
    }
}
