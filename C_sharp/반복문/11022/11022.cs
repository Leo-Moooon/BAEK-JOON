namespace _11022;
class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            result += "Case #" + i + ": " + A + " + " + B + " = " + (A + B) + "\n";
        }
        Console.WriteLine(result);
    }
}