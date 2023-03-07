namespace _2525_오븐시계_;
class Program
{
    static void Main(string[] args)
    {
        string[] time = Console.ReadLine().Split();
        double cook = int.Parse(Console.ReadLine());

        double total = (int.Parse(time[0]) * 60) + int.Parse(time[1]) + cook;
        double h = Math.Floor(total / 60);
        double m = total % 60;

        if (h >= 24)
        {
            h -= 24;
        }
        Console.WriteLine(h + " " + m);
    }
}