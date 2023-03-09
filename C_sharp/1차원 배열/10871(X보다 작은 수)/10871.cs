namespace _10871_X보다_작은_수_;
class Program
{
    static void Main(string[] args)
    {
        string[] NX = Console.ReadLine().Split();
        int N = int.Parse(NX[0]);
        int X = int.Parse(NX[1]);
        string[] A = Console.ReadLine().Split();
        string result = default;

        foreach (string i in A)
        {
            int num = int.Parse(i);
            if (num < X)
            {
                result += num + " ";
            }
        }
        Console.WriteLine(result);
    }
}