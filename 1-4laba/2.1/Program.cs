using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string familia, data;
        public int nomer;
        public int[] yspevaimost;

        public void writeInConsoleInfo(string familia, string data, int nomer, int[] yspevaimost)
        {
            Console.WriteLine("Фамилия: {0}\nДень рождение: {1}\nГруппа: {2}\n", familia, data, nomer);
            Console.WriteLine("Успеваемость:");
            foreach (int i in yspevaimost)
            {
                Console.Write(i + " ");
            }
        }


    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Student egor = new Student();
            egor.familia = "gurzo";
            egor.data = "29.12.2001";
            egor.nomer = 623;
            egor.yspevaimost = new[] { 5, 5, 2, 5, 1 };

            
            bool rabota = true;
            while (rabota)
            {
                Console.WriteLine("Введите 1 для вывода, 2 для изменения данных");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        egor.writeInConsoleInfo(egor.familia, egor.data, egor.nomer,
                            egor.yspevaimost);
                        
                        break;
                    case "2":
                        Console.WriteLine("Введите 1 для изменения фамилии, 2 дня рождения, 3 группы, 0 для вывода");
                        string b = Console.ReadLine();
                        {
                            switch (b)
                            {
                                case "1":
                                    Console.WriteLine("Введите новую фамилию");
                                    string newfamilia = Console.ReadLine();
                                    egor.familia = newfamilia;
                                    break;
                                case "2":
                                    Console.WriteLine("Введите новую дату дня рождения");
                                    string newdr = Console.ReadLine();
                                    egor.data = newdr;
                                    break;
                                case "3":
                                    Console.WriteLine("Введите новую группу");
                                    int newnomer = Convert.ToInt32(Console.ReadLine());
                                    egor.nomer = newnomer;
                                    break;
                                case "0":
                                    egor.writeInConsoleInfo(egor.familia, egor.data, egor.nomer,
                                        egor.yspevaimost);
                                    
                                    break;
                            }
                        }
                        break;

                }
            }

        }
    }
}
