namespace _25314_코딩은_체육과목입니다_;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= N / 4; i++)
        {
            result += "long ";
        }
        Console.WriteLine(result + "int");
    }
}