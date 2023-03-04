using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string rim = "XIV";
            var rimskiv = new Dictionary<char, int>()
            {
                { 'I',1 },
                { 'V',5 },
                { 'X',10 },
                { 'L',50 },
                { 'C',100 },
                { 'D',500 },
                { 'M',1000 },
            };

            int output = 0;
            for (int i = 0; i < rim.Length; i++)
            {
                if (i == rim.Length - 1)
                {
                    output += rimskiv[rim[i]];


                }
                else if (rimskiv[rim[i]] < rimskiv[rim[i + 1]])
                {
                    output += rimskiv[rim[i + 1]] - rimskiv[rim[i]];
                    i++;
                }
                else
                {
                    output += rimskiv[rim[i]];
                }
                
            }
            Console.WriteLine(output);
        }
    }
}
