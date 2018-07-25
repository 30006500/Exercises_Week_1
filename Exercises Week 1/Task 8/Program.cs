using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter you final mark");
            int Mark = int.Parse(Console.ReadLine());
            if (Mark >= 50)
            {
                Console.WriteLine("You have passed");
            }
            else
            {
                Console.WriteLine("Sorry, you failed");
            }

            Console.ReadLine();
        }
    }
}
