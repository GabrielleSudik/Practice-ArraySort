using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ArraySort
{
    //this will take an array of random ints and put them in order
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n; //declares a variable to represent length of array

            n = myArray.Length; //yeah.

            Console.WriteLine("Original array elements :");
            showArrayElements(myArray); //first time this runs, just prints array

            shellSort(myArray, n);  //runs the sort method

            Console.WriteLine("\nSorted array elements :");
            showArrayElements(myArray);  //this time it prints the sorted array

            Console.ReadLine();
        }

        static void shellSort(int[] arr, int arraySize)
        {
            int i, j, inc, temp; //guess you can declare multiple variables on one line?
            inc = 3;  //I think this starts comparing every third element?
            while (inc > 0)
            {
                for (i=0; i < arraySize; i++)
                {
                    //I know this is sorting in place, kind of like
                    //reversing an array in place
                    //but I can't quite follow the logic...

                    j = i;
                    temp = arr[i];
                    while((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }

                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;

            }
        }

        static void showArrayElements(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }
    }
}
