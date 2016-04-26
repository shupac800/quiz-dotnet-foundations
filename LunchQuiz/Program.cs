using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Order bob = new Order
            {
                Drink = "horchata",
                Entree = "burrito grande",
                //Dessert = "churro"
            };
            Console.WriteLine(bob.Drink);
            Console.WriteLine(bob.Entree);
            if (String.IsNullOrEmpty(bob.Dessert))
            {
                Console.WriteLine("null or empty");
            }
            else
            {
                Console.WriteLine(bob.Dessert);
            }

            bob.VerifyOrderComplete();
        }
    }
}
