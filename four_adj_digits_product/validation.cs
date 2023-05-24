using System;

namespace four_adj_digits_product
{
    //Implements edge cases method
    public class Validation
    {
        //Check with edge cases and throw any error
        public void EdgeCases(string number)
        {
            if (number == null)
            {
                throw new Exception("Input should be atleast four digits\nNull is not accepted");
            }
            if(number.Length < 4)
            {
                throw new Exception("Input should be atleast four digits\ngiven input is too small or less than four digits");
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < '0' && number[i] > '9')
                {
                    throw new Exception("Only numbers from 0-9 are accepted as input");
                }
            }
        }
    }
}
