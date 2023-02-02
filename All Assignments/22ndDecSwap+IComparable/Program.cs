using System;
using System.Collections;

//Create a Generic Method to swap two values
//   of a value type object which has implemented IComparable interface
namespace Generic
{
    class Mainclass
    {

        public static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap A={0},B={1}", a, b);
        }
        static void Main()
        {
            int i = 10;
            int j = 20;
            Swap<int>(i, j);
        }
    }
}
