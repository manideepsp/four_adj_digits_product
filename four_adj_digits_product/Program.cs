/***************************************************************************************
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
using System;

public class MainClass
{
    public static void Main()
    {
        //Number input in string format
        string stringOfNumbers = Console.ReadLine();
        Console.WriteLine(stringOfNumbers);

        int[] numberInt = new int[stringOfNumbers.Length];

        for (int i = 0, j = 0; i < stringOfNumbers.Length; i++)
        {
            if (stringOfNumbers[i] >= '0' && stringOfNumbers[i] <= '9')
            {
                numberInt[j++] = Convert.ToInt32(Convert.ToString(stringOfNumbers[i]));
            }
            else
            {
                throw new Exception("Enter numericals only");
            }
        }

        int maxProduct = 0;

        for (int i = 0; i < numberInt.Length - 3; i++)
        {
            maxProduct = numberInt[i] * numberInt[i + 1] * numberInt[i + 2] * numberInt[i + 3];
        }

        Console.WriteLine(maxProduct);
        //Console.WriteLine(numberInt[3]);
        Console.ReadKey();
    }
}

//Console.WriteLine(Convert.ToInt32(Convert.ToString(stringOfNumbers[1])));

