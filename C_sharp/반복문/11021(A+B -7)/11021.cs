namespace _11021_A_B__7_;
class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= T; i++)
        {
            string[] str = Console.ReadLine().Split();
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);

            result += "Case #" + i + ": " + (A + B) + "\n";
        }
            Console.WriteLine(result);
    }
}