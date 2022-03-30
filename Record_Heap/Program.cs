using System;
using System.IO;
namespace Record_Heap // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Sort records from least to greatest via key value");
            Console.WriteLine("Start by entering in records\n\n");
            char Again = 'y';
            MaxHeap heap = new MaxHeap();
            int tempID = 0;
            string tempName = " ";
            while (Again == 'y')
            {

                Console.WriteLine("Enter ID of record");
                try//make sure user inputs integer, break if else
                {
                    tempID = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex)
                { Console.WriteLine("ID must be numeric whole number");
                    Environment.Exit(0);
                }

                Console.WriteLine("Enter name of record");
                tempName = Console.ReadLine();
               
                heap.insertRecord(tempID, tempName);
                Console.WriteLine("\nEnter Another?");
                Again = Console.ReadLine()[0];
            }
         
            Console.WriteLine("Sort Records via Heapsort");
            Record[] recordsSorted = heap.Sort();
            heap.printRecords(recordsSorted);
            

        }
    }
}