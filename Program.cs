using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp3
{
    internal class program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int a=Convert .ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            int b=Convert .ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            Console.WriteLine(sum);
            

        }
    }
}
