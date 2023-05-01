using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndLoop_1
{
    /// <summary>
    /// Задание 1. Приложение по определению чётного или нечётного числа 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Сообщение
            Console.WriteLine("Задание 1. Приложение по определению чётного или нечётного числа" +
                "\nВведите проверяемое на чётность целое число");

            //чтение вводимой строки
            string inStr = Console.ReadLine();
            inStr = inStr.Trim();//удалить пробелы

            //проверка: введено число? 
            if (inStr != "" && inStr.All(Char.IsDigit))
            {
                //преобразование строки в число
                int inNumber = int.Parse(inStr);

                //определение чётности и вывод
                Console.WriteLine("Вы ввели " + ((inNumber % 2 == 0) ? "ЧЁТНОЕ " : "НЕЧЁТНОЕ ") + "число" +
                    "\nДля выхода нажмите любую клавишу");
            }
            else
            {
                Console.WriteLine("Вводить нужно только цифры !" +
                    "\nДля выхода нажмите любую клавишу");
            }

            Console.ReadKey();
        }
    }
}
