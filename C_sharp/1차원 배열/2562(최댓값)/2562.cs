using System;

namespace _2562_최댓값_;
class Program
{
    static void Main(string[] args)
    {
        int max = default;
        int count = default;

        for (int i = 0; i < 9; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
                count = i + 1;
            }
        }
        Console.WriteLine(max + "\n" + count);
    }
}