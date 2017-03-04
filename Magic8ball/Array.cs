using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8ball
{
    class Array
    {
        static void FunWithArrays()
        {
            // An array is an object that holds a fixed amount of values of a single type.
            

            // Here we create an array named 'values1' of type 'int' and assign it the values in between the brackets.
            int[] values1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Here we create an array named 'values2' of type 'long' and give it a length of 5.
            long[] values2 = new long[5];


            // In order to access individual elements in the array we use the subscript operator.

            // Here we assign the value 25 to the first element of values2.
            values2[0] = 25;


            // The length of an array is stored in it's 'Length' property.

            // For example here we assign the first element of values1 to be the length of values2.
            values1[0] = values2.Length;


            // These were basics of arrays.
            // There are many more properties and functions you can play with.
        }
    }
}
