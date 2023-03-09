using System;
using System.Linq;
namespace _10818_최소__최대_;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int[] ints = Array.ConvertAll(input, i => int.Parse(i));
        string result = ints.Min().ToString() + " " + ints.Max().ToString();

        Console.WriteLine(result);
    }
}