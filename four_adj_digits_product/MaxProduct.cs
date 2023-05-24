using System;

namespace four_adj_digits_product
{
    //Implements maximum product function
    public class Product
    {
        //Takes integer array and returns maximum of product of four consecutive digits
        public int MaxProduct(string number)
        {
            IntArray objectIntArray = new IntArray();
            int[] numberInt = objectIntArray.ToIntArray(number);
            int maximumProduct = 0, currentProduct = 0;

            for (int i = 0; i < numberInt.Length - 3; i++)
            {
                currentProduct = numberInt[i] * numberInt[i + 1] * numberInt[i + 2] * numberInt[i + 3]; //Product of four consecutive digits
                
                if(maximumProduct < currentProduct)
                {
                    maximumProduct = currentProduct;
                }
            }
            return maximumProduct;
        }
    }
}
