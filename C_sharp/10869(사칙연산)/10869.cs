namespace _10869_사칙연산_;
class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
        Console.WriteLine(int.Parse(str[0]) - int.Parse(str[1]));
        Console.WriteLine(int.Parse(str[0]) * int.Parse(str[1]));
        Console.WriteLine(Math.Floor(double.Parse(str[0]) / double.Parse(str[1])));
        Console.WriteLine(int.Parse(str[0]) % int.Parse(str[1]));
    }
}