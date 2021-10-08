using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class BubbleSort
    {
        private Node start;
        public  void BubbleSortList()
        { 
        Node p, q, end;

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }

                }
            }
        }
        public void CreateList()
        {
            int i, n, data;
            Console.WriteLine("Enter the no of nodes to be inserted");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for(i=1;i<=n;i++)
            {
                Console.WriteLine("Enter the numbers to be inserted");
                n = Convert.ToInt32(Console.ReadLine());
               


            }
        }

    }
}
