using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class IEnumerableDemo2
    {

        public IEnumerableDemo2()
        {
            List<int> numList = new List<int>() { 1, 3, 5 };
            int[] intArr = { 2, 4, 6 };
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(5);
            intQueue.Enqueue(10);
            intQueue.Enqueue(15);

            Console.WriteLine("Sum of the list");
            CollectionSum(numList);

            Console.WriteLine("Sum of the array");
            CollectionSum(intArr);

            Console.WriteLine("Sum of the queue");
            CollectionSum(intQueue);


        }

        public void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach(int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine("Sum is {0}", sum);
        }


    }
}
