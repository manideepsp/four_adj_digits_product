using System;

namespace four_adj_digits_product
{
    public class Validation
    {
        public void Validate(string stringOfNumbers)
        {
            if (stringOfNumbers == null)
            {
                Console.WriteLine("Input should be atleast four digits\nNull is not accepted");
            }
            if(stringOfNumbers.Length < 4)
            {
                Console.WriteLine("Input should be atleast four digits\ngiven input is too small or less than four digits");
            }
            for (int i = 0; i < stringOfNumbers.Length; i++)
            {
                if (stringOfNumbers[i] < '0' && stringOfNumbers[i] > '9')
                {
                    Console.WriteLine("Only numbers from 0-9 are accepted as input");
                }
            }
        }
    }
}
