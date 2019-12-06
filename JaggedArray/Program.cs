using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 1, 2, 3, 4, 5 };
            arr[1]= new int[] { 1, 3, 45, 56, 67, 78 };
            for (int i=0;i<arr.Length; i++)
            {
                for(int j=0; j<arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
