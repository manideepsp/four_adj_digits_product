using System;


namespace four_adj_digits_product
{
    //Implements ToIntArray method
    public class IntArray
	{
		//Takes string input and returns integer array
		public int[] ToIntArray(string number)
		{
			int[] numberInt = new int[number.Length];

			//Converts each character to integer and appends to integer array
			for (int i = 0, j = 0; i < number.Length; i++)
			{
				numberInt[j++] = Convert.ToInt32(Convert.ToString(number[i])); //converting character to string then to int32
			}
			return numberInt;
		}
	}
}
