using System;
using System.Text;

namespace _15552_빠른_A_B_;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder result = new StringBuilder();

        int T = int.Parse(Console.ReadLine());

        int[] A = new int[T];
        int[] B = new int[T];

        for (int i = 0; i < T; i++)
        {
            string[] str = Console.ReadLine().Split();
            A[i] = int.Parse(str[0]);
            B[i] = int.Parse(str[1]);

            result.AppendLine((A[i] + B[i]).ToString());
        }
            Console.WriteLine(result.ToString());
    }
}