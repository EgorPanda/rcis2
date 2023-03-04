using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                int setchik = 0;
                string s_stroka = "js";
                string j_stroka = "jjssccd";
                
                foreach (char s in s_stroka) { 
                    foreach (char j in j_stroka)
                    {
                        if (s == j) {
                        setchik++;
                        }

                    }
                }

                Console.WriteLine(setchik);
            }
        }
    }
}
