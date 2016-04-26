using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{

    public class Casual : Restaurant
    {
        public bool HasPatio { get; set; }

        public Casual()
        {
            this.MenuItems.Add(new MenuItem()
            {
                Name = "Jalapeno Cheese Poppers",
                Price = 5.99,
                Description = "Irresistible nuggets of death"
            });
        }
    }

}
