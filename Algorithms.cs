using System;

namespace HomeWork1
{
    public static class Algorithms
    {
        public static void Linear(int length)
        {
            Console.WriteLine("Linear algorithm");
            if (length < 0) throw new ArgumentException();
            for (int index = 0; index < length; index++)
                Console.WriteLine($"Index: {index}");
        }
        
        public static int LogarithmicIndexOf(int[] array, int value)
        {
            Console.WriteLine("Logarithmic algorithm");
            
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == value) return middle;
                if (array[middle] > value) right = middle - 1;
                else left = middle + 1;
            }

            return -1;
        }

        public static void Quadratic(int height, int width)
        {
            for (int k = 0; k < height; k++)
                for (int j = 0; j < width; j++)
                    Console.WriteLine($"Position: {k}-{j}");
        }
    }
}