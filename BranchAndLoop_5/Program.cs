using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndLoop_5
{
    /// <summary>
    /// Задание 5. Игра «Угадай число»
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.MaxValue;//генерируемое загадываемое число
            string inStr = "";
            bool isNumExists = false;//есть неотгаданное число
            int counter = 0;//число попыток

            Console.Write("Задание 5. Игра «Угадай число»");

            while(true)
            {
                if (isNumExists) //если есть загаданое число
                {
                    
                    Console.Write("Введите число: ");   //приглашение ввода числа для отгадывания
                    inStr = Console.ReadLine().Trim();  //считывание числа
                    if (inStr == "")
                    {
                        Console.WriteLine($"Загадано было {num}");
                        break;//выход при вводе пустой строки
                    }

                    if (int.TryParse(inStr, out int parsedNum))//Если стррока с числом введена корректно
                    {
                        if (parsedNum == num)//число угадано
                        {
                            isNumExists = false;
                            Console.WriteLine($"\nВы угадали! число попыток {counter}");
                        }
                        else//число не угадано
                        {
                            counter++;
                            Console.WriteLine("Введёное число "
                                            + (parsedNum > num ? "БОЛЬШЕ" : "МЕНЬШЕ")
                                            + " загаданного");
                        }
                    }
                    else Console.WriteLine("Число введено не корректно");
                }
                else//нет загаданного числа
                {
                    Console.Write("\nДля выхода введите пустую строку" +
                    "\nили введите величину максимального загадываемого числа: ");
                    inStr = Console.ReadLine().Trim();
                    if (inStr == "") break;

                    if (int.TryParse(inStr, out int parsedRange))//Если стррока с числом введена корректно
                    {
                        num = new Random().Next(parsedRange);//"загадывание" числа
                        counter = 0;//счётчик попыток. Его отрицательное значение - цикл прерван, число не отгадано
                        isNumExists = true;
                    }
                    else Console.WriteLine("Максимальное число задано не корректно");
                }
            }
        }
    }
}
