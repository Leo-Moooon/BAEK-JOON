namespace _14681_사분면_고르기_;
class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int isEven;

        if (y > 0)
        {
            isEven = x > 0 ? 1 : 2;
        }
        else
        {
            isEven = x > 0 ? 4 : 3;
        }

        Console.WriteLine(isEven);
    }
}


