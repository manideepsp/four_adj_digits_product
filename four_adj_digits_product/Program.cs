//***************Greatest product of 4 adjacent numbers in any given number**************

using four_adj_digits_product;
using System;


public class MainC
{
    public static void Main()
    {
        //input
        string number = Console.ReadLine();

        //validation
        Validation objectValidation = new Validation();
        objectValidation.EdgeCases(number);

        //objects
        IntArray objectIntArray = new IntArray();
        Product objectMaxProduct = new Product();

        //maxproduct returns greatestProduct
        Console.WriteLine(objectMaxProduct.MaxProduct(number));

        Console.ReadKey(); //keep output window
    }
}

//Console.WriteLine(Convert.ToInt32(Convert.ToString(stringOfNumbers[1])));

