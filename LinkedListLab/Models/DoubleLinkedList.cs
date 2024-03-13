
namespace LinkedListLab.Models
{
    public class DoubleLinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        private int _count = 0;

        public DoubleLinkedList(Node<T> node)
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
                CreateDoubleLinkedList(node);
            }
            else
            {
                node.Prev = _tail;
                _tail.Next = node;
                _tail = node;
            }
            _count++;
        }

        public void AddBeforeFirstNode(Node<T> node)
        {
            if (_head == null)
            {
                CreateDoubleLinkedList(node);
            }
            else
            {
                _head.Prev = node;
                node.Next = _head;
                _head = node;
                _head.Prev = null;
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
                CreateDoubleLinkedList(node);
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

                current.Next.Prev = node;
                node.Next = current.Next;

                node.Prev = current;
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
                _tail = _tail.Prev;
                _tail.Next = null;
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

            if (_head == null)
            {
                _tail = null;
            }
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
                Node<T> current;
                if (position < _count / 2)
                {
                    // Итерация с начала списка
                    current = _head;
                    for (int i = 0; i < position; i++)
                    {
                        current = current.Next;
                    }
                }
                else
                {
                    // Итерация с конца списка
                    current = _tail;
                    for (int i = _count - 1; i > position; i--)
                    {
                        current = current.Prev;
                    }
                }

                // Удаление узла
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
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



        private void CreateDoubleLinkedList(Node<T> node)
        {
            _head = node;
            _tail = node;
        }


    }
}
