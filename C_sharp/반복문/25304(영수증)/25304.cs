namespace _25304_영수증_;
class Program
{
    static void Main(string[] args)
    {
        int pay = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int total = 0;
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int Price = int.Parse(input[0]);
            int Quan = int.Parse(input[1]);

            total += Price * Quan;
        }
        string result = (pay == total) ? "Yes" : "No";
        Console.WriteLine(result);
    }
}