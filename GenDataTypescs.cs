using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsS
{
    public class GenDataTypescs
    {
        public static void Check<T>(T a)
        {
             // type of method return the data Types
            Console.WriteLine(typeof(T));
        }
    }
    public class programTwo
    {
        static void Main(string[] args)
        {
            GenDataTypescs.Check(10);
        }
    }
}
