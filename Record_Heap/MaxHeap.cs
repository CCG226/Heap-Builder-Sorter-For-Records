using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Heap
{
    public partial class MaxHeap
    {
        static Record[] Heap = new Record[10];
        static int currentAmount = 0;
        static int size = 10;
        
        private void Full()
        {
            size = size * 5;
            Heap = new Record[size];//make heap 5 times bigger
        }
       
        public void insertRecord(int id, string name)
        {
            if (currentAmount == size - 1)//if heap full, dynamically allocate new memory
            {
                Full();
            }

            Heap[currentAmount] = new Record();//create new record with user inputted content
            Heap[currentAmount].ID = id; 
            Heap[currentAmount].recordName = name;
          
            
            int parentNode = currentAmount / 2; 
            while(currentAmount > 0  && Heap[currentAmount].ID > Heap[parentNode].ID )//keep swapping new node with parent node if new node is a greater ID value or new node ends up on as root
            {
                Record New = Heap[currentAmount];
                Heap[currentAmount] = Heap[parentNode];
                Heap[parentNode] = New;
            }
            currentAmount++;

        }
       
 
        
    }
}
