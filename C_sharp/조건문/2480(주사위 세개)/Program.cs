namespace _2480_주사위_세개_;
class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        Array.Sort(str);
        int A = int.Parse(str[0]);
        int B = int.Parse(str[1]);
        int C = int.Parse(str[2]);
        int result = 0;

        if (A == B && B == C && C == A)
        {
            result = 10000 + (A * 1000);
        }
        else if (A != B || B != C || C != A)
        {
            if (A == B)
            {
                result = 1000 + (A * 100);
            }
            else if (B == C)
            {
                result = 1000 + (B * 100);
            }
            else if (C == A)
            {
                result = 1000 + (A * 100);
            }
            else
            {
                result = C * 100;
            }
        }
        Console.WriteLine(result);
    }
}

