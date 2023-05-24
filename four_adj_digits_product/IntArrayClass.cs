using System;


namespace four_adj_digits_product
{
	public class IntArrayClass
	{
		public int[] IntArray(string stringOfNumbers)
		{
			int[] numberInt = new int[stringOfNumbers.Length];

			//Converts each character to integer and appends to integer array
			for (int i = 0, j = 0; i < stringOfNumbers.Length; i++)
			{
				numberInt[j++] = Convert.ToInt32(Convert.ToString(stringOfNumbers[i]));
			}
			return numberInt;
		}
	}
}
