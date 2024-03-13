
using System.Xml.Linq;

namespace LinkedListLab.Models
{
    public class SingleLinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        private int _count = 0;

        public SingleLinkedList(Node<T> node)
        {
            _head = node;
            _tail = node;
            _count++;
        }

        public void Display()
        {
            Node<T>? current = _head;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void AddAfterLastNode(Node<T> node)
        {
            if (_head == null)
            {
                CreateSingleLinkedList(node);
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            _count++;
        }

        public void AddBeforeFirstNode(Node<T> node)
        {
            if (_head == null)
            {
                CreateSingleLinkedList(node);
            }
            else
            {
                node.Next = _head;
                _head = node;
            }
            _count++;
        }

        public void AddAfterSpecifiedPosition(int position, Node<T> node)
        {
            Node<T>? current = _head;

            if (position < 0 || position > _count)
            {
                throw new Exception("There is no such position!");
            }
            else if (_head == null)
            {
                CreateSingleLinkedList(node);
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

                current.Next = null;
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
            }
            _count--;
        }

        public void RemoveNodeAtSpecificPosition(int position)
        {
            Node<T>? current = _head;

            if (position < 0 || position > _count)
            {
                throw new Exception("There is no such position!");
            }
            else if (_head == null)
            {
                throw new Exception("List is empty!");
            }
            else if (position == 0)
            {
                RemoveFirstNode();
                return;
            }
            else if (position == _count-1)
            {
                RemoveLastNode();
                return;
            }
            else
            {
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }

                Node<T>? target = current.Next.Next;
                current.Next.Next = null;
                current.Next = target;

            }
            _count--;
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
                while (current != null)
                {
                    if (current.Data.Equals(value))
                    {
                        return position;
                    }
                    position++;
                    current = current.Next;
                }
            }

            return -1;
        }

        private void CreateSingleLinkedList(Node<T> node)
        {
            _head = node;
            _tail = node;
        }

    }
}
