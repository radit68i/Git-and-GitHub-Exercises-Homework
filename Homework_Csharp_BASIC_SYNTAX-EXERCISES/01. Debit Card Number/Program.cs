using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirthNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:D4} {secondNum:D4} {thirthNum:D4} {forthNum:D4}");
        }
    }
}
