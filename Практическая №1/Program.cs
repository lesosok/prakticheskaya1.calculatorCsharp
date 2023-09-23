using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Procedure = 0;

            do
            {
                Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
                Console.WriteLine("1. Сложить два числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент из числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы\n");

                try
                {
                    Procedure = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Введён неверный тип данных. Повторите попытку\n");
                    continue;
                }

                double number1 = 0;
                double number2 = 0;
                double result = 1;

                switch (Procedure)
                {
                    case 1:
                        Console.WriteLine("Введите первое число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 + number2;
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 2:
                        Console.WriteLine("Введите первое число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 - number2;
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 3:
                        Console.WriteLine("Введите первое число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 * number2;
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 4:
                        Console.WriteLine("Введите первое число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        if (number2 == 0)
                        {
                            Console.WriteLine("Деление на ноль невозможно. Повторите попытку\n");
                            break;
                        }
                        result = number1 / number2;
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 5:
                        Console.WriteLine("Введите первое число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень, в которую нужно возвести число ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = Math.Pow(number1, number2);
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 6:
                        Console.WriteLine("Введите число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        result = Math.Sqrt(number1);
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 7:
                        Console.WriteLine("Введите число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        result = number1 / 100;
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 8:
                        Console.WriteLine("Введите число ");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i <= number1; i++)
                        {
                            result = result * i;
                        }
                        Console.WriteLine("Результат: " + result + "\n");
                        break;

                    case 9:
                        Console.WriteLine("Вы вышли из программы");
                        break;

                    default:
                        Console.WriteLine("Операции с таким номером нет. Повторите попытку\n");
                        break;
                }
            } while (Procedure != 9);
        }
    }
}
