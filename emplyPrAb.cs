using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class emplyPrAb
    {
        static void Main(string[] args)
        {
            int Is_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 1);
            if (empCheck == Is_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
