using System;
using Xunit;
using HelloDotNet;

namespace HelloDotNetTest
{
    public class TestAlgoritmo
    {
        [Fact]
        public void TestbinarySearch()
        {
            int[] testInts = { 2, 25, 5, 51, 3, 11, 56, 81, 2, 4, 1 };
            bool found = Program.BinarySearch(testInts, 80, 0, testInts.Length - 1);
            Assert.True(found);
            found = Program.BinarySearch(testInts, 79, 0, testInts.Length - 1);
            Assert.False(found);
        }
    }
}
