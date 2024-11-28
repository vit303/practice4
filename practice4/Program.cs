using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4
{
    internal class Program
    {
        static void Main()
        {
            IntegerNumbersArrayCollection collection = new IntegerNumbersArrayCollection();

            // Создаем и добавляем массивы
            IntegerNumbersArray array1 = new IntegerNumbersArray();
            array1.AddNumber(2);
            array1.AddNumber(4);
            array1.AddNumber(6);
            collection.AddArray(array1);

            IntegerNumbersArray array2 = new IntegerNumbersArray();
            array2.AddNumber(1);
            array2.AddNumber(3);
            collection.AddArray(array2);

            IntegerNumbersArray array3 = new IntegerNumbersArray();
            array3.AddNumber(2);
            array3.AddNumber(4);
            array3.AddNumber(8);
            collection.AddArray(array3);

            IntegerNumbersArray array4 = new IntegerNumbersArray();
            array4.AddNumber(5);
            collection.AddArray(array4);

            // Запросы
            Console.WriteLine("Массивы только с четными элементами: " + collection.GetEvenArrays().Count);
            Console.WriteLine("Массив с наибольшей суммой элементов: " + string.Join(", ", collection.GetArrayWithMaxSum()?.GetList() ?? new List<int>()));
            Console.WriteLine("Массив с минимальным количеством элементов: " + string.Join(", ", collection.GetArrayWithMinCount()?.GetList() ?? new List<int>()));
            Console.WriteLine("Количество массивов, содержащих значение 2: " + collection.CountArraysContainingValue(2));
            Console.WriteLine("Количество уникальных размеров массивов: " + collection.CountUniqueSizes());
            Console.WriteLine("Упорядоченный массив массивов по первому элементу: ");
            var orderedArrays = collection.GetOrderedArraysByFirstElement();
            foreach (var arr in orderedArrays)
            {
                Console.WriteLine(string.Join(", ", arr.GetList()));
            }
        }
    }
}
