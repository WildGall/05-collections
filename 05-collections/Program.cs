using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 1, 3, 12, 24, 55, 17, 34 };
            int[] arrayTwo = { 1, 3, 13, 44, 55, 26, 3 };
            List<int> unitedArray = new List<int>();

            AssignValue(unitedArray, arrayOne);
            AssignValue(unitedArray, arrayTwo);
            RemoveDuplicateItems(unitedArray);

            for (int i = 0; i < unitedArray.Count; i++)
            {
                Console.Write($"{unitedArray[i]} ");
            }
        }
        
        static void AssignValue(List<int> allArray, int[] elementaryArray)
        {
            for (int i = 0; i < elementaryArray.Length; i++)
            {
                allArray.Add(elementaryArray[i]);
            }
        }

        static void RemoveDuplicateItems(List<int> allArray)
        {
            for (int i = 0; i < allArray.Count; i++)
            {
                for (int j = i + 1; j < allArray.Count; j++)
                {
                    if (allArray[i] == allArray[j])
                    {
                        allArray.RemoveAt(j);
                    }
                }
            }
        }
    }
}
