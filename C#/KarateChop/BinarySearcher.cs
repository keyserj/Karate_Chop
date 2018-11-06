namespace KarateChop
{
    public class BinarySearcher
    {
        private readonly int[] _ints;

        public BinarySearcher(int[] ints)
        {
            _ints = ints;
        }

        public int Find(int element)
        {
            int low = 0;
            int high = _ints.Length - 1;

            while (low <= high)
            {
                int middle = (high + low) / 2;
                if (_ints[middle] == element)
                {
                    return middle;
                }
                else if (_ints[middle] > element)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return -1;
        }
    }
}