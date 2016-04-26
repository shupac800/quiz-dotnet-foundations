using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FastFood : Restaurant
    {
        public bool HasDriveThrough { get; set; }

        public FastFood()
        {
            this.MenuItems = new List<MenuItem>();
        }
    }
}
