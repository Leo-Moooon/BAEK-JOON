namespace _5597_과제_안_내신_분_;
class Program
{
    static void Main(string[] args)
    {
        int[] student = new int[30];
        int input;
        string result = default;

        for (int i = 0; i < 30; i++)
        {
            student[i] = (i+1);
        }

        for (int j = 0; j < 28; j++)
        {
            input = int.Parse(Console.ReadLine());
            student = student.Where(el => el != input).ToArray();
        }

        foreach (int k in student)
        {
            result += k + "\n";
        }

        Console.WriteLine(result);
    }
}

