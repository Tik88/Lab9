using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор! ");
            try
            {
                double a, b = 0;
                char Sum;
                Console.WriteLine("Введите 1 число ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите действие (+, -, *, /) ");
                Sum = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (Sum != '0')
                {
                    Console.WriteLine("Введите 2 число ");
                    b = double.Parse(Console.ReadLine());
                }
                switch (Sum)
                {
                    case '+':
                        Console.WriteLine("Решение = {0}+{1}={2}", a, b, a + b);
                        break;
                    case '-':
                        Console.WriteLine("Решение = {0}-{1}={2}", a, b, a - b);
                        break;
                    case '*':
                        Console.WriteLine("Решение = {0}*{1}={2}", a, b, a * b);
                        break;
                    case '/':
                        Console.WriteLine("Решение = {0}/{1}={2}", a, b, a / b);
                        break;                    
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
