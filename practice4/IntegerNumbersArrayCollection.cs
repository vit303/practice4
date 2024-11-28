using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4
{
    internal class IntegerNumbersArrayCollection
    {
        private List<IntegerNumbersArray> arrays = new List<IntegerNumbersArray>();

        public void AddArray(IntegerNumbersArray array)
        {
            arrays.Add(array);
        }

        // Массивы только с четными элементами
        public List<IntegerNumbersArray> GetEvenArrays()
        {
            var evenArrays = from arr in arrays
                             where arr.IsEvenArray()
                             select arr;
            return evenArrays.ToList();
        }

        // Массив с наибольшей суммой элементов
        public IntegerNumbersArray GetArrayWithMaxSum()
        {
            var maxSumArray = (from arr in arrays
                               orderby arr.GetSum() descending
                               select arr).FirstOrDefault();
            return maxSumArray;
        }

        // Массив с минимальным количеством элементов
        public IntegerNumbersArray GetArrayWithMinCount()
        {
            var minCountArray = (from arr in arrays
                                 orderby arr.Count
                                 select arr).FirstOrDefault();
            return minCountArray;
        }

        // Количество массивов, содержащих заданное значение
        public int CountArraysContainingValue(int value)
        {
            var count = (from arr in arrays
                         where arr.GetList().Contains(value)
                         select arr).Count();
            return count;
        }

        // Количество уникальных размеров массивов
        public int CountUniqueSizes()
        {
            var uniqueSizes = (from arr in arrays
                               select arr.Count).Distinct().Count();
            return uniqueSizes;
        }

        // Упорядоченный массив массивов по первому элементу
        public List<IntegerNumbersArray> GetOrderedArraysByFirstElement()
        {
            var orderedArrays = from arr in arrays
                                orderby arr.GetList().FirstOrDefault()
                                select arr;
            return orderedArrays.ToList();
        }
    }
}
