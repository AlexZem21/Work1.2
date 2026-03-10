using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, -4, 12, 56, -4 };
        int count = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] * numbers[i + 1] < 0)
            {
                count++;
            }
        }
        Console.WriteLine("Исходная последовательность: {" + string.Join(", ", numbers) + "}");
        Console.WriteLine("Количество смен знака: " + count);
    }
}
