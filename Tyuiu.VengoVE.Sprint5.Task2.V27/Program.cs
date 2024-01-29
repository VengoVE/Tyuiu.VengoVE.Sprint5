using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VengoVE.Sprint5.Task2.V27.Lib;

namespace Tyuiu.VengoVE.Sprint5.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 1, 4, 3},
                                          { 1, 1, 4},
                                          { 4, 3, 8}};

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;


            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Вэнго В. Э. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Вэнго В. Э. | ИСПб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: = " + res);
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
