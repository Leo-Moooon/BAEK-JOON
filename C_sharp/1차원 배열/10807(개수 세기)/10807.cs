namespace _10807_개수_세기_;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int v = int.Parse(Console.ReadLine());
        int count = 0;

        foreach (string el in input)
        {
            int num = int.Parse(el);
            if( v == num) count++;
        }
        Console.WriteLine(count);
    }
}