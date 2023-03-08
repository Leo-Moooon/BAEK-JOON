namespace _15552_빠른_A_B_;
class Program
{
    static void Main(string[] args)
    {
        double T = double.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string[] str = Console.ReadLine().Split();
            double A = double.Parse(str[0]);
            double B = double.Parse(str[1]);
            Console.WriteLine(A + B);
        }
    }
}