using System;


namespace four_adj_digits_product
{
    /// <summary>
	/// Implements ToIntArray method
	/// </summary>
    public class IntArray
	{
        /// <summary>
        /// Takes string input and returns integer array
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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
