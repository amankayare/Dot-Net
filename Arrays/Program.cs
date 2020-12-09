using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main1(string[] args)
        {
         // -> when we create an int array it inherit from System.Array class which is abstract class therefore "arr" is the derived class of System.Array abstract class
         // so all porperties and functions are available in our array

            int[] arr = new int[5];

            for (int i =0; i< arr.Length; i++)
            {
                Console.Write("Enter element no {0}: ", i);// {0} will be replaced by value of i here {0}-> represent 1st value , here {1}-> represent 2nd value 
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            // Properties and methods of Array class 
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element no {0}: ", i);// {0} will be replaced by value of i here {0}-> represent 1st value , here {1}-> represent 2nd value 
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }


            Array.Clear(arr,3,2); // para1-> array ,para2-> start clearing from , para3-> clear till
            int[] arr2 = new int[5];
            Array.Copy(arr, arr2, 3); // copy array elements
            Array.ConstrainedCopy(arr,2,arr2,3,1); // work like a transactions either all should copy or none of them should
            Array.CreateInstance(typeof(int),5); // para1-> type of array , para2-> size of array
            int position = Array.IndexOf(arr, 10);// returns -1 if not found , if 2 values are there then it will return 1st occurance position
            int pos = Array.BinarySearch(arr, 10);// array should be sorted already
            Array.Reverse(arr);
            Array.Sort(arr);



            Console.ReadLine();
        }

        static void Main3(string[] args)
        {
            // Multidimentional Array
            int[,] arr = new int[5,3];//2D -> no. of commas will be one less then dimension of an array

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1);  j++)
                {
                    Console.Write("Enter marks for Student number {0} and subject {1} ", i, j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            // arr.GetLength(0)-> length of 1st dimension
            // arr.GetLength(1)-> length of 2nd dimension
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Enter marks for Student number {0} and subject {1} is  : {2}", i, j, arr[i, j]);
                }
            }
           
            Console.WriteLine(arr.Rank);// -> how many dimensions
            Console.WriteLine(arr.GetUpperBound(0));// -> upperBound of 1st dimensions
            Console.WriteLine(arr.GetUpperBound(1));// -> upperBound of 2nd dimensions

            Console.WriteLine(arr.GetLowerBound(0));// -> lowerBound of 1nd dimensions
            Console.WriteLine(arr.GetLowerBound(1));// -> lowerBound of 2nd dimensions

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            // 5 rows, each row has 3 col
            // int[,] arr = new int[5,3];
            
            // Multidimentional Array
            int[][] arr = new int[3][]; // -> also known as jagged array

            // 5 rows , each row has diff cols
            // array of arrays

            arr[0] = new int[3];// arr[0][0] - arr[0][2]
            arr[1] = new int[2];
            arr[2] = new int[1];
            // arr[0] -> [][][]
            // arr[1] -> [][][][][]

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Enter marks for Student number {0} and subject {1} ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Enter marks for Student number {0} and subject {1} is  : {2}", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        }
    }
}
