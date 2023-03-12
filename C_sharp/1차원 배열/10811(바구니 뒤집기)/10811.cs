namespace _10811_바구니_뒤집기_;
class Program
{
    static void Main(string[] args)
    {
        // 입력 단계
        string[] NM = Console.ReadLine().Split();
        int N = int.Parse(NM[0]);
        int M = int.Parse(NM[1]);
        string result = default;
        int[] basket = new int[N];

        for (int a = 0; a < N; a++)
        {
            basket[a] = a + 1;
        }
        // 뒤집기 단계
        for (int b = 0; b < M; b++)
        {
            string[] ij = Console.ReadLine().Split();

            if (ij == null) break;

            int i = int.Parse(ij[0])-1;
            int j = int.Parse(ij[1])-1;

            Array.Reverse(basket, i, j-i+1);
        }

        // 출력 단계
        foreach (int c in basket)
        {
            result += c + " ";
        }

        Console.WriteLine(result);
    }
}