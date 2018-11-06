using KarateChop;
using Xunit;

namespace KarateChopTests
{
    public class BinarySearcherTests
    {
        private int[] _ints;

        private void AssertFind(int element, int expectedPos)
        {
            BinarySearcher binarySearcher = new BinarySearcher(_ints);

            int actualPos = binarySearcher.Find(element);
            Assert.Equal(expectedPos, actualPos);
        }

        [Theory]
        [InlineData(5, -1)]
        public void Find_from_empty_list(int element, int expectedPos)
        {
            _ints = new int[] { };

            AssertFind(element, expectedPos);
        }

        [Theory]
        [InlineData(5, 0)]
        [InlineData(6, -1)]
        public void Find_from_list_of_one(int element, int expectedPos)
        {
            _ints = new int[] { 5 };

            AssertFind(element, expectedPos);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(5, 1)]
        [InlineData(2, -1)]
        public void Find_from_list_of_two(int element, int expectedPos)
        {
            _ints = new int[] { 1, 5 };

            AssertFind(element, expectedPos);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(5, 2)]
        [InlineData(9, -1)]
        public void Find_from_list_of_three(int element, int expectedPos)
        {
            _ints = new int[] { 1, 2, 5 };

            AssertFind(element, expectedPos);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(4, 1)]
        [InlineData(6, 2)]
        [InlineData(73, 3)]
        [InlineData(7, -1)]
        public void Find_from_list_of_four(int element, int expectedPos)
        {
            _ints = new int[] { 1, 4, 6, 73 };

            AssertFind(element, expectedPos);
        }

        [Theory]
        [InlineData(8, 0)]
        [InlineData(9, 1)]
        [InlineData(10, 2)]
        [InlineData(11, 3)]
        [InlineData(12, 4)]
        [InlineData(13, -1)]
        public void Find_from_list_of_five(int element, int expectedPos)
        {
            _ints = new int[] { 8, 9, 10, 11, 12 };

            AssertFind(element, expectedPos);
        }
    }
}