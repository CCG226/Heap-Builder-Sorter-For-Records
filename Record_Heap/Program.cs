using System;
using System.IO;
namespace Record_Heap // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Build MaxHeap\n\n");
            char Again = 'y';
            MaxHeap heap = new MaxHeap();
            int tempID = 0;
            string tempName = " ";
            while (Again == 'y')
            {

                Console.WriteLine("Enter ID of record");
                tempID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name of record");
                tempName = Console.ReadLine();
                heap.insertRecord(tempID, tempName);
                Console.WriteLine("\nEnter Another?");
                Again = Console.ReadLine()[0];
            }

            Console.WriteLine("Sort Records via Heap"
        }
    }
}