using System;
using System.Collections;
using System.Collections.Generic;

namespace Project1
{
    public class Node<T>
    {
        public Node<int> Next { get; set; }
        public int Data { get; set; }

        public Node(int t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<int> head;
        private Node<int> tail;

        public GenericList()
        {
            tail = head = null;
        }
        public Node<int> Head
        {
            get => head;
        }
        public void Add(int t)
        {
            Node<int> n = new Node<int>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
            List<int> list = new List<int>();
            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }
            int sum = 0;
            list.ForEach(x => Console.WriteLine(x));
            list.ForEach(delegate (int x) { sum += x; });
            list.ForEach(i => sum += i);
        }
    }

}
