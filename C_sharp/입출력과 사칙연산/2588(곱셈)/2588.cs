namespace _2588_곱셈_;
class Program
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        Console.WriteLine(int.Parse(str1) * (int)Char.GetNumericValue(str2[2]));
        Console.WriteLine(int.Parse(str1) * (int)Char.GetNumericValue(str2[1]));
        Console.WriteLine(int.Parse(str1) * (int)Char.GetNumericValue(str2[0]));
        Console.WriteLine(int.Parse(str1) * int.Parse(str2));
    }
}