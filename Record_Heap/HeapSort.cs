using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Heap
{
    public partial class MaxHeap
    {
     
        private Record pullTopRecord()
        {
            int root = 0;
            Record temp = Heap[0];//sawp root with last record in the back of the heap to make reorginaztion easier and done via comaparsion 
            Heap[0] = Heap[currentAmount - 1];
            Heap[currentAmount - 1] = temp;
            currentAmount--;
            if(currentAmount != 0)
            {
                reorganizeTree(root); //resort if tree isnt empty
            }

            return Heap[currentAmount];
            
        }
        public Record[] Sort()
        {
           Record[] SortedList = new Record[currentAmount];
            for (int i = SortedList.Length - 1; i >= 0; i--)//start from end of records array so max value is in the back
            {
                SortedList[i] = new Record();
                SortedList[i] = pullTopRecord();//pull max value root
            }
            return SortedList;
        }
        private void reorganizeTree(int root)
        {
            int Leftpos = ((root * 2) + 1);//leftchild
            int Rightpos = ((root * 2) + 2);//rightchild
            int tempRoot = root;//thier root
            if(Leftpos < currentAmount && Heap[Leftpos].ID > Heap[tempRoot].ID)//compare left child to parent and set subroot to left child if left child is larger
            {
                tempRoot = Leftpos;
            }
            if(Rightpos < currentAmount && Heap[Rightpos].ID > Heap[tempRoot].ID)//same as above but with right child
            {
                tempRoot = Rightpos;
            }
            if(tempRoot != root)//root must be biggest value for Maxheap
            {
                Record temp = Heap[root];//if not swap root with a new root of the larger child
                Heap[root] = Heap[tempRoot];
                Heap[tempRoot] = temp;
                reorganizeTree(tempRoot);//recall via recursion 

            }
        }
    }
}
