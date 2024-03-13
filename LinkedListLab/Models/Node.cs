using System.Collections;

namespace LinkedListLab.Models
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }
        public Node<T>? Prev { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public void DisplayNode()
        {
            if (typeof(IEnumerable).IsAssignableFrom(typeof(T)))
            {
                foreach (var item in (IEnumerable)Data)
                {
                    Console.WriteLine(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(Data);
            }

        }
    }
}
