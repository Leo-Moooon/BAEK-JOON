namespace _10810_공_넣기_;
class Program
{
    static void Main(string[] args)
    {
        string[] NM = Console.ReadLine().Split();
        int N = int.Parse(NM[0]);
        int M = int.Parse(NM[1]);
        int[] ints = new int[N];
        string result = default;
        for (int a = 0; a < M; a++)
        {
            string[] ijk = Console.ReadLine().Split();
            int i = int.Parse(ijk[0]);
            int j = int.Parse(ijk[1]);
            int k = int.Parse(ijk[2]);

            for (int b = i-1; b < j; b++)
            {
                ints[b] = k;
            }
        }
        string[] iToStr = Array.ConvertAll(ints, el => el.ToString());

        foreach (string c in iToStr)
        {
            result += c + " ";
        }
        Console.WriteLine(result);
    }
}