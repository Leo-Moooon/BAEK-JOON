namespace _2438_별_찍기__1_;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        string star = "";
        string result = "";
        for (int i = 0; i < N; i++)
        {
            star += "*";
            result += star + "\n";
        }
        Console.WriteLine(result);
    }
}