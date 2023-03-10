namespace _10813_공_바꾸기_;
class Program
{
    static void Main(string[] args)
    {
        string[] NM = Console.ReadLine().Split();
        int N = int.Parse(NM[0]);
        int M = int.Parse(NM[1]);
        int[] ints = new int[N];

        for (int a = 1; a <= N; a++)
        {
            ints[a-1] = a;
        }

        for (int a = 0; a < M; a++)
        {
            string[] input = Console.ReadLine().Split();
            int i = int.Parse(input[0]);
            int j = int.Parse(input[1]);

            int tmp = ints[i-1];
            ints[i-1] = ints[j-1];
            ints[j-1] = tmp;
        }

        string result = default;

        foreach (int a in ints)
        {
            result += a + " ";
        }
        Console.WriteLine(result);
    }
}