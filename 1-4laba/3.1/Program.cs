
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Worker
    {
        public string name, surname;
        public int days, rate;

        public void GetSalary()
        {
            Console.WriteLine($"ЗАРПЛАТА -  {days * rate}");
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Worker sanya = new Worker();
            sanya.name = "shuric";
            sanya.surname = "lukianov";
            sanya.days = 5;
            sanya.rate = 40;
            sanya.GetSalary();
        }
    }
}
