using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndLoop_3
{
    /// <summary>
    /// Задание 3. Проверка простого числа
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //приглашение ввести число для проверки
            Console.WriteLine("Задание 3. Проверка простого числа" +
                "\nВведите целое число:");

            //чтение введённой строки
            string inStr = Console.ReadLine();
            inStr = inStr.Trim();//удалить пробелы


            if (inStr != "" && inStr.All(Char.IsDigit))//если строка не пустая и были введены только цифры
            {
                int testedNumber = int.Parse(inStr);
                if (testedNumber > 1)
                {
                    //признак простого числа
                    bool isSimple = true;

                    //Цикл поиска делителя
                    for (int i = 2; i < testedNumber; i++)
                    {
                        if (testedNumber % i == 0)//если остаток от деления нулевой (деление нацело)
                        {
                            isSimple = false;   //значит число не простое.
                            break;              //цикл можно прервать
                        }
                    }
                    Console.WriteLine($"Введённое число {testedNumber} -" + (isSimple ? "" : " НЕ") + " является простым" +
                        "\nДля выхода нажмите любую клавишу");
                }
                else Console.WriteLine($"Вы ввели {testedNumber}. Число должно быть болоьше 1 !" +
                    $"\nДля выхода нажмите любую клавишу");
            }
            else Console.WriteLine("Вводить надо не пустую строку и только цифры !" +
                "\nДля выхода нажмите любую клавишу");

            Console.ReadKey();
        }
    }
}
