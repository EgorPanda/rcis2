using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2._5
{

    class chubrik {
        private string name;
        private string surname;

        public chubrik() { name = "Неизвестно"; surname = "Неизвестно"; }
        public chubrik(string name,string surname) { this.name = name; this.surname = surname; }

        public void GetPrint()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
        }

        ~chubrik()
        {
            Console.WriteLine($"{name} has deleted");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            chubrik men1 = new chubrik("ivan","petrovich");
            chubrik men2 = new chubrik();
            men1.GetPrint();
            men2.GetPrint();
            Console.WriteLine("лялялял");


        }
    }
}
