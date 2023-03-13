namespace _1546_평균_;
class Program
{
    static void Main(string[] args)
    {
        // 입력 단계 
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        double result = default;

        // 점수 오름차순으로 정렬 및 최고점 확인 
        double[] scores = Array.ConvertAll(input, el => double.Parse(el));
        Array.Sort(scores);
        double max = scores[^1];


        // 점수 조작
        for (int i = 0; i < N; i++)
        {
            scores[i] = (scores[i] / max) * 100;
        }

        // 평균 도출
        foreach (double j in scores)
        {
            result += j;
        }

        // 출력
        Console.WriteLine(result/N);
    }
}

