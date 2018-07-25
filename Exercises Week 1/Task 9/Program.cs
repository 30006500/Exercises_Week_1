using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    public class Program
    {
        public static void Main()
        {
            string[] names = new string[] {"John", "Mary", "Steve", "Andy", "Dave"};
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
