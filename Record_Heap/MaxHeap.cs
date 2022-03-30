using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Heap
{
    public partial class MaxHeap
    {
        static Record[] Heap = new Record[1];
        static int currentAmount = 0;
        static int size = 1;

        private void Full()
        {
            size = size * 5;
            Heap = new Record[size];
        }
        public void insertRecord(int id, string name)
        {
            if (currentAmount == size - 1)
            {
                Full();
            }

            Heap[currentAmount] = new Record();
            Heap[currentAmount].ID = id; 
            Heap[currentAmount].recordName = name;
          
            
            int parentNode = currentAmount / 2; 
            while(currentAmount > 0  && Heap[currentAmount].ID > Heap[parentNode].ID )
            {
                Record New = Heap[currentAmount];
                Heap[currentAmount] = Heap[parentNode];
                Heap[parentNode] = New;
            }
            currentAmount++;

        }
 
        public void printHeap()
        {
            for(int i = 0; i < currentAmount; i++)
            {
                Console.WriteLine(Heap[i].ID + " ");
            }
        }
    }
}
