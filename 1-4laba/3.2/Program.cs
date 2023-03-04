
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Worker
    {
        private string name, surname;
        private int days, rate;


        public void SetNew(string name, string surname,int days, int rate) {
            this.name = name;
            this.surname = surname;
            this.days = days;
            this.rate = rate;
        
        }
        public void GetPrint()
        {
            Console.WriteLine($"имя - {name}\n" +
                $"фамилия - {surname}\n" +
                $"дни - {days}\n" +
                $"ставка - {rate}\n" +
                $"ЗАРПЛАТА -  {days * rate}");
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Worker Aleksandr = new Worker();
            
            Aleksandr.SetNew("шурик","лукьянов",100,20);
            Aleksandr.GetPrint();
        }
    }
}
