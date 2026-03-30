//Установить, является ли последовательность цифр при просмотре их слева направо упорядоченной по возрастанию.
//Например, для последовательности 1,4,7,8 ответ положительный, для чисел 1,7,8,2 и 1,6,6,8 — отрицательный и т. п.
using System;

class Program
{
    static void Main()
    {
        // Ввод количества цифр
        Console.Write("Введите количество цифр в последовательности: ");
        int n = int.Parse(Console.ReadLine());

        // Логика проверки количества и вывод ошибки
        if (n < 2)
        {
            Console.WriteLine("Ошибка: количество цифр должно быть не менее 2.");
            Console.ReadLine();
            return;
        }

        // Создаём массив для хранения последовательности
        int[] numbers = new int[n];

        // Ввод первой цифры
        Console.Write("Введите цифру 1: ");
        numbers[0] = int.Parse(Console.ReadLine());

        bool isIncreasing = true; // флаг упорядоченности

        // Цикл ввода остальных цифр с проверкой
        for (int i = 1; i < n; i++)
        {
            Console.Write($"Введите цифру {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            // Проверка возрастания (сравниваем с предыдущим)
            if (numbers[i] <= numbers[i - 1])
            {
                isIncreasing = false;
            }
        }

        // Формируем строку с последовательностью для вывода
        string sequenceStr = "{" + string.Join(", ", numbers) + "}";

        // Вывод результата с последовательностью
        if (isIncreasing)
        {
            Console.WriteLine($"Последовательность {sequenceStr} упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine($"Последовательность {sequenceStr} НЕ упорядочена по возрастанию.");
        }

        Console.ReadLine();
    }
}
