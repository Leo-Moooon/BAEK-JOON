namespace _10591_A_B__4_;
class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            string str = Console.ReadLine();
            if (str == null) break;
            string[] AB = str.Split();
            int A = int.Parse(AB[0]);
            int B = int.Parse(AB[1]);

            Console.WriteLine(A+B);
        }
    }
}