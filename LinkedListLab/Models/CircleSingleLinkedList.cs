using System;

namespace LinkedListLab.Models
{
    public class CircleSingleLinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        private int _count = 0;

        public CircleSingleLinkedList(Node<T> node)
        {
            _head = node;
            _tail = node;
            _tail.Next = _head;
            _count++;
        }

        public void Display()
        {
            if (_head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node<T>? current = _head;
            do
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            while (current != _head);
        }

        public void AddAfterLastNode(Node<T> node)
        {
            if (_head == null)
            {
                CreateCircleSingleLinkedList(node);
            }
            else
            {
                _tail.Next = node;
                _tail = node;
                _tail.Next = _head;
            }
            _count++;
        }

        public void AddBeforeFirstNode(Node<T> node)
        {
            if (_head == null)
            {
                CreateCircleSingleLinkedList(node);
            }
            else
            {
                node.Next = _head;
                _head = node;
                _tail.Next = _head;
            }
            _count++;
        }

        public void AddAfterSpecifiedPosition(int position, Node<T> node)
        {
            if (position < 0 || position > _count)
            {
                throw new Exception("Invalid position!");
            }
            else if (_head == null)
            {
                CreateCircleSingleLinkedList(node);
            }
            else if (position == 0)
            {
                AddBeforeFirstNode(node);
            }
            else if (position == _count)
            {
                AddAfterLastNode(node);
            }
            else
            {
                Node<T>? current = _head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }

                node.Next = current.Next;
                current.Next = node;
            }
            _count++;
        }

        public void RemoveLastNode()
        {
            if (_head == null)
            {
                throw new Exception("List is empty!");
            }
            else if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                Node<T>? current = _head;
                while (current.Next != _tail)
                {
                    current = current.Next;
                }
                current.Next = _head;
                _tail = current;
            }
            _count--;
        }

        public void RemoveFirstNode()
        {
            if (_head == null)
            {
                throw new Exception("List is empty!");
            }
            else if (_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                _head = _head.Next;
                _tail.Next = _head;
            }
            _count--;
        }

        public void RemoveNodeAtSpecificPosition(int position)
        {
            if (position < 0 || position >= _count)
            {
                throw new Exception("Invalid position!");
            }
            else if (_head == null)
            {
                throw new Exception("List is empty!");
            }
            else if (position == 0)
            {
                RemoveFirstNode();
            }
            else if (position == _count - 1)
            {
                RemoveLastNode();
            }
            else
            {
                Node<T>? current = _head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }
                Node<T>? target = current.Next.Next;
                current.Next.Next = null;
                current.Next = target;
                _count--;
            }
        }

        public int SearchByValue(T value)
        {
            if (value == null)
            {
                throw new Exception("Null value");
            }
            else
            {
                Node<T>? current = _head;
                int position = 0;
                do
                {
                    if (current.Data.Equals(value))
                    {
                        return position;
                    }
                    position++;
                    current = current.Next;
                }
                while (current != _head);
            }
            return -1;
        }

        private void CreateCircleSingleLinkedList(Node<T> node)
        {
            _head = node;
            _tail = node;
            _tail.Next = _head;
        }
    }
}
