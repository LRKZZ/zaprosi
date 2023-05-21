class Program
{
    static void Main()
    {
        // Исходный массив
        Console.WriteLine("Заполните массив через пробел: ");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Запросы
        var positiveNumbers = array.Where(n => n > 0);
        var negativeSum = array.Where(n => n < 0).Sum();
        var multiplesOfFiveCount = array.Count(n => n % 5 == 0);

        // Вывод результатов запросов
        Console.WriteLine("Положительные числа: " + string.Join(", ", positiveNumbers));
        Console.WriteLine("Сумма отрицательных: " + negativeSum);
        Console.WriteLine("Кол-во кратных 5: " + multiplesOfFiveCount);

        // Удаление четных элементов
        array = array.Where(n => n % 2 != 0).ToArray();

        // Запросы после удаления четных элементов
        positiveNumbers = array.Where(n => n > 0);
        negativeSum = array.Where(n => n < 0).Sum();
        multiplesOfFiveCount = array.Count(n => n % 5 == 0);

        // Вывод результатов запросов после удаления четных элементов
        Console.WriteLine("Положительные числа после удаления чётных эл-тов: " + string.Join(", ", positiveNumbers));
        Console.WriteLine("Сумма отрицательных после удаления чётных эл-тов: " + negativeSum);
        Console.WriteLine("Кратные 5 числа после удаления чётных эл-тов: " + multiplesOfFiveCount);

        Console.ReadKey();
    }
}