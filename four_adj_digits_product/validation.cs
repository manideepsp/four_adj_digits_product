using System;

namespace four_adj_digits_product
{
    /// <summary>
    /// Implements edge cases method
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Check with edge cases and throw any error
        /// </summary>
        /// <param name="number"></param>
        /// <exception cref="Exception"></exception>
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
