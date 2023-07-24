using System;
namespace Starting
{
    class Intro
    {
        public static void Main(string[] args)
        {
            //array declaration how to use 
            //type--1 using string
            string[] array1 = new string[3];
            array1[0] = "sai";
            array1[1] = "priya";
            array1[2] = "jaya";
            Console.WriteLine("type1 string");
           for (int i=0; i<array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            //type--1 using integer
            int[] array2= new int[3];
            array2[0] = 12;
            array2[1] = 13;
            array2[2] = 14;

            Console.WriteLine("type1 integer");
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);

            //type--2 using string 
            string[] array3 = { "hello", "hi", "strin" };
            Console.WriteLine("type2 string");
            foreach (string s in array3)
            {
                Console.Write(s);
            }

            //type--2 using integer
            int[] arr1 = { 20, 30, 40 };
            Console.WriteLine("type2 integer");
            foreach (int s in arr1)
            {
                Console.Write(s);
            }


            //type--3 using string
            string[] arr3 = new string[] { "my", "hi", "test" };
            Console.WriteLine("type3 string");
            Console.WriteLine(arr3[0]);
            Console.WriteLine(arr3[1]);
            Console.WriteLine(arr3[2]);

            //type--3 using integer
            int[] array5 = new int[] { 10, 20, 30 };
            Console.WriteLine("type3 integer");
            Console.WriteLine(array5[0]);
            Console.WriteLine(array5[1]);
            Console.WriteLine(array5[2]);
            // reverse
            int[] h = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            for(int i = h.Length - 1; i >= 0; i--)
            {
                Console.Write(i);
            }

            //IndexOF
            Console.WriteLine("");

            int[] a = new int[] { 10, 20, 30, 40, 50, 80,30 };
            int b = Array.IndexOf(a, 40);

            Console.WriteLine("The indexof is return the position given number" + b);
            // if it occurance is 2 types we use this position index  Linear search
            int c = Array.IndexOf(a, 30, 3);
            Console.WriteLine("the position of second occurance" + c);

            // Binary search should be always in the sorted order 
            Console.WriteLine("");
            int[] e = new int[] { 10, 20, 30, 40, 50,60,70};
            int f = Array.BinarySearch(e,20);
            Console.WriteLine("this is binary search {0}",f);

            //System.Array.clear()--> it is used set to zero and clear elements in the array 
            double[] l = new double[] { 45, 35, 67, 89, 200, 100 };
            Array.Clear(l, 0, 5);
            Console.WriteLine("this is clear ");
            foreach (var o in l)
            {
                Console.WriteLine(o);
            }

            //Array.Resize() --> this method is used to resize the array it can be increase / decrease the array size
            int[] A = new int[] { 20, 30, 50 };
            Array.Resize(ref A, 5);
            Console.WriteLine("this array resizing");
            foreach(var H in A)
            {
                Console.WriteLine(H);
            }

            //Array.Sort()--> this is used to sort the elements in ascending order 
            int[] B = new int[] { 89, 70, 34, 67, 20, 10 };
            Array.Sort(B);
            System.Console.WriteLine("it is sort method ");
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
            //Array.Reverse()
            int[] C = new int[] { 10, 20, 30, 40, 50 };
            Array.Reverse(C);
            Console.WriteLine("Reverse the array");
            foreach (int H in C)
            {
                Console.WriteLine(H);
            }
        }
    }
}
