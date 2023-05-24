using System;


namespace four_adj_digits_product
{
    public class IntArrayClass
    {
        public int[] IntArray(string stringOfNumbers)
        {
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
            return numberInt;
        }
    }
}
