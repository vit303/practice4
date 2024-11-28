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
        private int count = 0;

        public IntegerNumbersArray() {

        }

        public IntegerNumbersArray(int number)
        {
            array.Add(number);
            this.count++;
        }

        public void AddNumber(int num) {
            array.Add(num);
            this.count++;
        }

        public List<int> GetList() {
            return array;
        }
    }
}
