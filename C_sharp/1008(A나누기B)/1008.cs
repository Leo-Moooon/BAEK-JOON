namespace _1008_A나누기B_;
class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        Console.WriteLine(double.Parse(str[0]) / double.Parse(str[1]));
    }
}

