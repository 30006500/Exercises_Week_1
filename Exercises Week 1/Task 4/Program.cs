using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your first name");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", Firstname, Lastname);
            Console.ReadLine();


        }
    }
}
