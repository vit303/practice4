using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4
{
    internal class IntegerNumbersArray
    {
        private List<int> array = new List<int>();

        public IntegerNumbersArray() { }

        public IntegerNumbersArray(int number)
        {
            array.Add(number);
        }

        public void AddNumber(int num)
        {
            array.Add(num);
        }

        public List<int> GetList()
        {
            return array;
        }

        public int GetSum()
        {
            return array.Sum();
        }

        public bool IsEvenArray()
        {
            return array.All(num => num % 2 == 0);
        }

        public int Count => array.Count;
    }
}
