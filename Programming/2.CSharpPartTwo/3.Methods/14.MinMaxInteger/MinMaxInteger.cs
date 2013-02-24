using System;


    class MinMaxInteger
    {
        static void Main()
        {
           
                Console.WriteLine("Enter array length  ");
                int length = int.Parse(Console.ReadLine());
                double[] arrayNumbers = new double[length];
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write(" {0} ", i);
                    arrayNumbers[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                double tempMin = Min(arrayNumbers);
                Console.WriteLine("The min number  is: {0}", tempMin);
                double tempMax = Max(arrayNumbers);
                Console.WriteLine("The greatest number in the sequence is: {0}", tempMax);
                double tempSum = Sum(arrayNumbers);
                Console.WriteLine("The sum of all the numbers in the sequence is: {0}", tempSum);
                double tempAverage = Average(arrayNumbers);
                Console.WriteLine("The average value of all the numbers in the sequence is: {0}", tempAverage);
                double tempProduct = Product(arrayNumbers);
                Console.WriteLine("The product of all the numbers in the sequence is: {0}", tempProduct);
            
            
        }

        static double Min(params double[] arr)
        {
            double min = double.MaxValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] <= min)
                {
                    min = arr[j];
                }
            }

            return min;
        }

        static double Max(params double[] arr)
        {
            double max = double.MinValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] >= max)
                {
                    max = arr[j];
                }
            }

            return max;
        }

        static double Sum(params double[] arr)
        {
            double sum = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                sum = sum + arr[k];
            }

            return sum;
        }

        static double Average(params double[] arr)
        {
            double average = Sum(arr) / arr.Length;
            return average;
        }

        static double Product(params double[] arr)
        {
            double product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }

            return product;
        }
    }
