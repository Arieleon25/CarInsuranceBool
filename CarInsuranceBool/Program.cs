using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceBool
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            int sTicket = 0;

            Console.WriteLine("What is your age?");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            sTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualification = Age > 15 && sTicket <= 3 && DUI == false;
            Console.WriteLine(qualification);

            Console.ReadLine();
        }
    }
}
