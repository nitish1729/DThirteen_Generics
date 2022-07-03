using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GenericsS
{
    public class MaxNumGen1
    {
     public static bool Check<T>(T a, T b) 
        {
            bool c = a.Equals(b);
            return c;
        }
    }
    class program 
    {
    public static void Main(string[] args)
        {
            Console.WriteLine(MaxNumGen1.Check(50,30));
            Console.ReadLine();
        }
        
    }
}
