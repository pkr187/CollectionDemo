using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100,"raja");
            dictionary.Add(100, "raja");
            dictionary.Add(100, "raja");
            dictionary.Add(100, "raja");
            Console.WriteLine("Access value using key(key=100):" + dictionary[100]);
            Console.WriteLine("\nItrating dictionary:");
            foreach (var element in dictionary )
            {
                Console .WriteLine ("key=" +element .Key+"&value=" +element .Value );

            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack .Push ("raj");
            stack.Push("raj");
            stack.Push("raj");
            stack.Push("raj");
            string pop = stack.Pop();
            foreach (var element in stack )
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element:" + pop);
        }
        private static void doQueueDemo()
        {
            Console.WriteLine ("\nIn doQueueDemo");
            Queue <string > queue = new Queue <string> ();
            queue.Enqueue("raj");
            queue.Enqueue("rajkumar");
            queue.Enqueue("devraj");
            queue.Enqueue("rab");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");
            foreach (var element in queue )
            {
                Console.WriteLine (element);
                String dequeue = queue.Dequeue();
                Console.WriteLine ("dequeue element:" +dequeue );
                Console.WriteLine("\nIterating the queue elemets after dequeue one element:");
                Queue <String >.Enumerator enumerator = queue.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine (enumerator.Current);
                }
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\nIN doSetDemo");
            var set = new HashSet <string>();
            set .Add("raja");
            set .Add("devraj");
            set .Add("rajkumar");
            set .Add("raj");
            HashSet <string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }       
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("raja");
            list.Add("devraj");
            list.Add("rajkumar");
            list.Add("raj");
            foreach (var element in list )
            {
                Console.WriteLine(element);
            }
        }
    }
}
