using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string str;
            int[] nums = { 1,  4, 3, 2,1 };
            bool a = false;

            for (int j = 0; j < nums.Length-1; j++)
            {
                for (int i = 1+j; i < nums.Length; i++)
                {
                    if (nums[j] == nums[i])
                    {
                        a = true;
                    }
                }
            }

            if (a == false)
            {
                str = "False";
            }
            else
            {
                str = "True";
            }

            Console.WriteLine(str);
        }
    }
}
