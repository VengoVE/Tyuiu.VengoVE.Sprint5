using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.VengoVE.Sprint5.Task5.V17.Lib;

namespace Tyuiu.VengoVE.Sprint5.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Вэнго В. Э. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Вэнго В. Э. | ИСПб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл (файл взять из архива согласно вашему варианту. Создать папку  *");
            Console.WriteLine("* в ручную и скопировать в неё файл) в котором есть набор значений.       *");
            Console.WriteLine("* Найти сумму всех простых целых чисел в файле. Полученный результат      *");
            Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх знаков    *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\ASUS\source\repos\Tyuiu.VengoVE.Sprint5\Tyuiu.VengoVE.Sprint5.Task5.V17\bin\Debug\InPutDataFileTask5V17.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
