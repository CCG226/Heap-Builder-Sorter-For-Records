using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Heap
{
    public partial class MaxHeap
    {
        public void printRecords(Record[] List)
        {
            for (int i = 0; i < List.Length; i++)//simple print method
            {
                Console.WriteLine("Record " + i + ":");
                Console.WriteLine("ID: " + List[i].ID);
                Console.WriteLine("Name: " + List[i].recordName);
                Console.WriteLine("\n");
            }
        }
    }
}
