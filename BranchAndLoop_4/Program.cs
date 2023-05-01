using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndLoop_4
{
    /// <summary>
    /// Задание 4. Наименьший элемент в последовательности
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;//минальное значение последовательности

            Console.Write("Задание 4. Наименьший элемент в последовательности" +
                "\nВведите длину последовательности: ");

            string inStr = Console.ReadLine();
            inStr = inStr.Trim();//удалить пробелы

            if (inStr != "" && inStr.All(Char.IsDigit))//проверка что вводимая строка целое число
            {
                int lenght = int.Parse(inStr);//преобразование строки в число для длительности последовательности
                if (lenght > 0)
                {
                    //цикл получения чисел последовательности
                    for (int i = 0; i < lenght; i++)
                    {
                        Console.Write("Введите целое число: ");

                        inStr = Console.ReadLine();
                        inStr = inStr.Trim();//удалить пробелы
                        if (inStr == "")
                        {
                            Console.WriteLine("Вводить надо не пустую строку и только цифры !");
                            continue;
                        }
                        string subStr = inStr.Substring(1, inStr.Length - 1);

                        //оценка введённого значения на минимум последовательности
                        if (inStr != "" && inStr.All(Char.IsDigit)
                            || (inStr[0] == '-' && subStr.All(Char.IsDigit)))
                        {
                            int val = int.Parse(inStr);
                            if (val < min) min = val;
                        }
                        else Console.WriteLine("Вводить надо не пустую строку и только цифры !");
                    }

                    //Вывод минимального значения последовательности
                    Console.Write($"Минимум: {min}\nДля выхода нажмите любую клавишу");
                }
                else Console.WriteLine("Длина последовательности должна содержать хотябы один элемент !" +
                    "\nДля выхода нажмите любую клавишу");
            }
            else Console.WriteLine("Вводить надо не пустую строку и только цифры !" +
                "\nДля выхода нажмите любую клавишу");

            Console.ReadKey();
        }
    }
}
