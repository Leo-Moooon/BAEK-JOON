using System.Linq;
namespace _3052_나머지_;
class Program
{
    static void Main(string[] args)
    {
        // 변수 선언 단계
        int[] num = new int[10];
        int[] newNum = default;


        // 42로 나눈 나머지 구하는 단계
        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());
            num[i] = input % 42;
        }

        // 중복 제거 단계
        newNum = num.Distinct().ToArray();

        // 출력 단계
        Console.WriteLine(newNum.Length);
    }
}

