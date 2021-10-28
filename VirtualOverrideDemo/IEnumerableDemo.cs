using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class IEnumerableDemo
    {
        
        
        public IEnumerableDemo()
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(2);

            foreach(int i in unknownCollection)
            {
                Console.WriteLine(i);
            }
        }
        
        
        IEnumerable<int> GetCollection(int option)
        {

            List<int> numList = new List<int> { 1, 2, 3, 4, 5 };


            Queue<int> numQueue = new Queue<int>();
            numQueue.Enqueue(6);
            numQueue.Enqueue(7);
            numQueue.Enqueue(8);
            numQueue.Enqueue(9);
            numQueue.Enqueue(10);
           


            if (option == 1)
            {
                return numList;
            } 
            else if(option == 2) 
            {
                return numQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }
    }

    

}
