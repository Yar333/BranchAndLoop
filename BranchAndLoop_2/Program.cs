using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAndLoop_2
{
    /// <summary>
    /// Задание 2. Программа подсчёта суммы карт в игре «21»
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            //Программа приветствует пользователя и спрашивает, сколько у него на руках карт.
            Console.WriteLine("Задание 2. Программа подсчёта суммы карт в игре «21»" +
                "\nПривет! Сколько карт у Вас на руках?");

            //чтение вводимой строки
            string inStr = Console.ReadLine();
            inStr = inStr.Trim();//удалить пробелы

            //проверка: введено число? 
            if (inStr.All(Char.IsDigit))
            {
                //Преобразовать введённую стрроку в количество карт
                int cardCount = int.Parse(inStr);

                //просим пользователя ввести номинал каждой карты
                Console.WriteLine("Далее введите карты по одной. " +
                    "\nДля карт с числовым номиналом надо ввести только цифру (от 2 до 10)." +
                    "\nДля 'картинок' следует принять обозначения латинскими буквами:" +
                    "\nВалет = J\tДама = Q\tКороль = K\tТуз = T");

                for (int i = 0; i < cardCount; i++)
                {
                    Console.Write($"Введите номинал следующей карты: ");
                    inStr = Console.ReadLine();
                    inStr = inStr.Trim();//удалить пробелы

                    //Если введены только цифры
                    if (inStr.All(Char.IsDigit))
                    {
                        //Преобразовать введённую строку в число
                        int weightCard = int.Parse(inStr);

                        //проверка на действительность карты с таким весом и подсчёт суммарного веса
                        if (weightCard > 1 && weightCard < 11)
                        {
                            sum += weightCard;
                        }
                        else
                        {
                            Console.WriteLine($"! {weightCard} - такой карты не бывает !");
                        }
                    }
                    else //Если введены НЕ только цифры
                    {
                        switch (inStr)
                        {
                            case "j":
                            case "J":
                            case "q":
                            case "Q":
                            case "k":
                            case "K":
                            case "t":
                            case "T": sum += 10; break;
                            default: Console.WriteLine($"! {inStr} - такой карты не бывает !"); break;
                        }
                    }
                }
                Console.WriteLine($"Сумма карт {sum}" +
                    $"\nДля выхода нажмите любую клавишу");
            }
            else
            {
                Console.WriteLine("Количество карт введено не корректно !" +
                    "\nДля выхода нажмите любую клавишу");
            }
            Console.ReadKey();
        }
    }
}
