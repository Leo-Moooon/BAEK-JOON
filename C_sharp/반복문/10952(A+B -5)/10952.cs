namespace _10952_A_B__5_;
class Program
{
    static void Main(string[] args)
    {
        int A = 1, B = 1;
        string result = "";

        while ( A != 0 && B != 0)
        {

            string[] str = Console.ReadLine().Split();
             A = int.Parse(str[0]);
             B = int.Parse(str[1]);
            if (A == 0 && B == 0) break;

            result += (A + B) + "\n";

        }
        Console.WriteLine(result);
    }
}