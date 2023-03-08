namespace _2439_별_찍기__2_;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        string space = "";
        string star = "";
        string result = "";

        for (int i = 1; i <= N; i++)
        {
            for (int j = N; j > i; j--)
            {
                space += " ";
            }
            star += "*";
            result += space + star + "\n";
            space = "";
        }
        Console.WriteLine(result);
    }
}

