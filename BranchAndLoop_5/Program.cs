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
            int inNum = 0;//вводимое для отгадывания число

            Console.Write("Задание 5. Игра «Угадай число»" +
                "\n\nДля выхода введите любой символ кроме цифр или пустую строку" +
                "\nВведите величину максимального загадываемого числа: ");

            string inStr = Console.ReadLine();
            inStr = inStr.Trim();

            if (inStr != "" && inStr.All(Char.IsDigit))//проверка что вводимая строка целое число
            {
                num = new Random().Next(int.Parse(inStr));//"загадывание" числа
                int counter = 0;//счётчик попыток. Его отрицательное значение - цикл прерван, число не отгадано
                while (num != inNum)//выйти если число отгадано
                {
                    Console.Write("\nВведите число: "); //приглашение ввода числа
                    inStr = Console.ReadLine();         //считывание числа

                    if (inStr != "" &&              //если строка не пустая
                        inStr.All(Char.IsDigit))    //и все введённые символы - цифры
                    {
                        inNum = int.Parse(inStr);   //преобразовать введённую строку в число
                        if (num != inNum)           //если число не угадано, то сообщить "в какую сторону" не угадано
                            Console.WriteLine("Введёное число "
                                + (inNum > num ? "БОЛЬШЕ" : "МЕНЬШЕ")
                                + " загаданного");
                    }
                    else//выход из цикла при не отгаданном числе
                    {
                        Console.WriteLine($"\nЖаль, но Вы не отгадали.\nЗагаданное число было {num}\nНажмите любую клавишу");
                        counter = -1;//признак того, что число не отгадано
                        break;//прерывание цикла
                    }

                    counter++;//счётчик попыток
                }
                if (counter > 0)//если выход из цикла был по отгаданному числу
                    Console.WriteLine($"\nВы угадали! число попыток {counter}\nДля выхода нажмите любую клавишу");
            }
            else Console.WriteLine("\nДля выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
