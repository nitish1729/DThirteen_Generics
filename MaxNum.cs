using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsS
{
   public class MaxNum
    {
        public static void Maxx(int a, int b, int c)
        {
         if (a > b && a >c)
            {
                Console.WriteLine("The Maximum number is : " + a);
            }
         else if(b >c && b > a)
            {
                Console.WriteLine("The Maximum number is : " + b);
            }
         else
            {
                Console.WriteLine("The Maximum number is : " + c);
            }
        }

        public static void Main(string[] args)
        {
            MaxNum check = new MaxNum();
            MaxNum.Maxx(10,50,0);
        }
    }

}
