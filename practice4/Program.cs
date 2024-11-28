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
            List<IntegerNumbersArray> array = new List<IntegerNumbersArray>();
            for (int i = 0; i < 3; i++) {
                
                while (true) {
                    try
                    {
                        int num = Convert.ToInt32(Console.ReadLine());
                        array[i].AddNumber(num);
                    }
                    catch {
                        break;
                    }
                }
            }

        }
    }
}
