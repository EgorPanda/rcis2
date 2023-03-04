using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void unique_combination(int l, int sum, int K,
                List<int> local,
                List<int> A)
        {

            if (sum == K)
            {
                Console.Write("{");
                for (int i = 0; i < local.Count; i++)
                {
                    if (i != 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(local[i]);

                    if (i != local.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("}");
                return;
            }

            for (int i = l; i < A.Count; i++)
            {

                if (sum + A[i] > K)
                    continue;

                if (i > l && A[i] == A[i - 1])
                    continue;

                local.Add(A[i]);

                unique_combination(i + 1, sum + A[i], K, local,
                    A);

                local.RemoveAt(local.Count - 1);
            }
        }

        static void Combination(List<int> A, int K)
        {
            A.Sort();

            List<int> local = new List<int>();

            unique_combination(0, 0, K, local, A);
        }

        static void Main(String[] args)
        {
            int[] arr = { 10, 1, 2, 7, 6, 1, 5 };
            List<int> A = new List<int>(arr);

            int K = 11;


            Combination(A, K);
        }
    }
}