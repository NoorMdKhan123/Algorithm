using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class Node
    {

        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}
