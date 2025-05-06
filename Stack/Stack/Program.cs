namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    public class CustomStack
    {
        private readonly char[] _items;
        private int _topIndex;
        private readonly int _capacity;

        public CustomStack(int size)
        {
            _topIndex = -1;
            _capacity = size;
            _items = new char[_capacity];
        }

        public bool Push(char item)
        {
            if (!IsFull())
            {
                _items[++_topIndex] = item;
                return true;
            }
            return false;
        }

        public char Pop()
        {
            if (!IsEmpty())
            {
                return _items[_topIndex--];
            }
            return '!';
        }

        public bool IsEmpty() => _topIndex == -1;

        public bool IsFull() => _topIndex == _capacity - 1;
    }
}
