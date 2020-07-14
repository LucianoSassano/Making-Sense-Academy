using System;
using System.Linq;


namespace Ms_Udemy_Course.Section5
{
    public class userSeriesInput
    {

        public userSeriesInput() { }


        public int returnBiggerNumberofSeries()
        {

            Console.WriteLine("Enter a series of itegers separated by comma");

            string integerSeries = Console.ReadLine();
            string[] splitValues = integerSeries.Split(',');


            for (int i = 0; i < splitValues.Length; i++)
            {

                splitValues[i] = splitValues[i].Trim();

            }

            int[] integerArray = new int[splitValues.Length];

            for (int i = 0; i < splitValues.Length; i++)
            {

                integerArray[i] = Convert.ToInt32(splitValues[i]);

            }


            return integerArray.Max();
        }

    }
}
