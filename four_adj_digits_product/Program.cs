﻿/***************************************************************************************
 ***************Greatest product of 4 adjacent numbers in any given number**************
 ***************************************************************************************
 *
 * Testcases:
 * 
 * 1. What if 0 is given, then output should be zero.
 * 2. What if a number is given which cannot be held by long(int32) datatype,
 *    still it should return max product.
 * 3. What if any characters other than numericals are given as input, then it
 *    should throw an exception.
 * *************************************************************************************/
using four_adj_digits_product;
using System;
using System.Numerics;


public class MainClass
{
    public static void Main()
    {
        //Number input in string format
        string stringOfNumbers = Console.ReadLine();


        IntArrayClass objectIntArray = new IntArrayClass();

        MaxProductCLass objectMaxProduct = new MaxProductCLass();

        //maxproduct returns the maximum consective product obtained from the given
        //number which is present in integer array and integer array is given by the
        //method IntArray by converting the input string into integer array

        Console.WriteLine(objectMaxProduct.MaxProduct(objectIntArray.IntArray(stringOfNumbers)));

        //Console.WriteLine(numberInt[3]);
        Console.ReadKey(); //To keep output window opened till any key is pressed
    }
}

//Console.WriteLine(Convert.ToInt32(Convert.ToString(stringOfNumbers[1])));

