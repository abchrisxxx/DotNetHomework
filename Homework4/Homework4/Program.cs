using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Node<T> { 
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> h = head;
            while (h != null)
            {
                action(h.Data);
                h = h.Next;
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            GenericList <int> list= new GenericList<int>();
            for (int i = 0; i < 10; i++) {
                list.Add(i);
            }
            Console.WriteLine("The list is:");
            //print list
            list.ForEach(i => Console.Write($"{i} "));
            //max in list
            int max = int.MinValue;
            list.ForEach(delegate (int i) { if (i > max) max = i; });
            Console.WriteLine($"\nThe max value of this list is:{max}");
            // min in list
            int min = int.MaxValue;
            list.ForEach(delegate (int i) { if (i < min) min = i; });
            Console.WriteLine($"The min value of this list is:{min}");
            //sum of list
            int sum = 0;
            list.ForEach(i => sum += i);
            Console.WriteLine($"The sum of this list is:{sum}");
        }

    }
}
