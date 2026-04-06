using System;

class Logic
{
    // Проверка, возрастает ли последовательность
    public static bool Check(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] <= numbers[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Формирование сообщения
    public static string Message(int[] numbers, bool isUp)
    {
        string sequenceStr = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i > 0)
            {
                sequenceStr += ", ";
            }
            sequenceStr += numbers[i];
        }
        
        sequenceStr = "{" + sequenceStr + "}";

        if (isUp)
        {
            return $"Последовательность {sequenceStr} упорядочена по возрастанию";
        }
        else
        {
            return $"Последовательность {sequenceStr} НЕ упорядочена по возрастанию";
        }
    }
    public static int ParseInt(string input)
    {
        if (input == null || input == "")
        {
            return -1; 
        }

        // Проверка, что все символы - цифры
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < '0' || input[i] > '9')
            {
                return -1;
            }
        }

        // Проверка на переполнение (не более 4 цифр)
        if (input.Length > 4)
        {
            return -1;
        }
        return int.Parse(input);
    }

    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int result = ParseInt(input);
            if(result != -1)
            {
                return result;
            }
            Console.WriteLine("Ошибка: необходимо ввести целое число (только цифры, без букв и знаков). Попробуйте снова.");
        }
    }

    public static int ReadCount()
    {
        while (true)
        {
            int count = ReadInt("Введите количество цифр в последовательности(от 2 до 15): ");
            if (count >= 2 && count <= 15)
            {
                return count;
            }
            if (count < 2)
            {
                Console.WriteLine("Ошибка: количество цифр должно быть не менее 2. Попробуйте снова.");
            }
            else
            {
                Console.WriteLine("Ошибка: количество цифр должно быть не более 15. Попробуйте снова.");
            }
        }
    }

    public static int[] ReadSequence(int count)
    {
        int[] nums = new int[count];
        for (int i = 0; i < count; i++)
        {
            nums[i] = ReadInt($"Цифра {i + 1}: ");
        }
        return nums;
    }
}

class Program
{
    static void Main()
    {
        int n = Logic.ReadCount();
        int[] nums = Logic.ReadSequence(n);

        bool isIncreasing = Logic.Check(nums);
        string result = Logic.Message(nums, isIncreasing);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}