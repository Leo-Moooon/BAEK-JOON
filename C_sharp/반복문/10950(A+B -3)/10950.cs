namespace _10950_A_B__3_;
class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < T; i++)
        {
            string[] AB = Console.ReadLine().Split();
            int A = int.Parse(AB[0]);
            int B = int.Parse(AB[1]);

            Console.WriteLine(A + B);
        }
    }
}