//***************Greatest product of 4 adjacent numbers in any given number**************

using four_adj_digits_product;
using System;


public class MainClass
{
    public static void Main()
    {
        //Number input in string format
        string stringOfNumbers = Console.ReadLine();

        //validation
        Validation objectValidation = new Validation();
        objectValidation.Validate(stringOfNumbers);

        //objects creation
        IntArrayClass objectIntArray = new IntArrayClass();
        MaxProductCLass objectMaxProduct = new MaxProductCLass();

        //maxproduct returns the maximum consective product obtained from the given
        //number which is present in integer array and integer array is given by the
        //method IntArray by converting the input string into integer array

        Console.WriteLine(objectMaxProduct.MaxProduct(objectIntArray.IntArray(stringOfNumbers)));

        Console.ReadKey(); //To keep output window opened till any key is pressed
    }
}

//Console.WriteLine(Convert.ToInt32(Convert.ToString(stringOfNumbers[1])));

