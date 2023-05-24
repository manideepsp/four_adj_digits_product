using System;

namespace four_adj_digits_product
{
    public class MaxProductCLass
    {
        public int MaxProduct(int[] numberInt)
        {
            int maxProduct = 0, currentProduct = 0;

            for (int i = 0; i < numberInt.Length - 3; i++)
            {
                currentProduct = numberInt[i] * numberInt[i + 1] * numberInt[i + 2] * numberInt[i + 3];
                
                if(maxProduct < currentProduct)
                {
                    maxProduct = currentProduct;
                }
            }
            return maxProduct;
        }
    }
}
