namespace senchenkosviridenko
{

class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Сумма: {num1 + num2}");
            Console.WriteLine($"Разность: {num1 - num2}");
            Console.WriteLine($"Произведение: {num1 * num2}");
            Console.WriteLine($"Частное: {num1 / num2}");
        }
    }
}

