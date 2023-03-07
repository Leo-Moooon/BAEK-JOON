namespace _2884_알람시계_;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        int h = int.Parse(input[0]);
        int m = int.Parse(input[1]) - 45;

        if (m < 0)
        {
            m += 60;
            h = h == 0 ? 23 : h-1;
        }
            Console.WriteLine(h + " " + m);
    }
}