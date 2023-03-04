using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Storage
    {
        private int number;

        public void SetP(int  number) {
            this.number = number;
        }

        public void SetR() {
            Random rnd = new Random();
            number = rnd.Next(1000);
        }

        public void GetPrint() {
            Console.WriteLine($"Ваше текущее значение: {number}");
            
        }
        

        public void plus() {
        number++;
        }

        public void minus()
        {
            number--;
        }


    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Storage number = new Storage();
            bool b = true;
            while (b)
            {
                Console.WriteLine("Введите:\n 1 для создания счетчика со своим начальным числом \n 2 для СОЗДАНИЯ СЧЕТЧИКА СО СЛУЧАЙНЫМ ЧИСЛОМ \n 3 для вывода числа \n 4 увеличить на один \n 5 уменьшить на один");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        Console.WriteLine("Ввдите начальное число");
                        number.SetP(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "2":
                        number.SetR();
                        break;
                    case "3":
                        number.GetPrint();
                        break;
                    case "4":
                        number.plus();
                        break;
                    case "5":
                        number.minus();
                        break;

                }
            }
        }
    }
}
