using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace WorkingWithArrays.Tests
{
    [TestFixture]
    public sealed class CopyingArrayTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }, 0, ExpectedResult = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }, 0, ExpectedResult = new[] { 1, 2, 3, 4, 5, 60, 70, 80, 90 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }, 4, ExpectedResult = new[] { 10, 20, 30, 40, 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }, 0, ExpectedResult = new[] { 1, 2, 3, 4, 5, 60, 70, 80, 90 })]
        public int[] Copy1_CopyElements(int[] source, int[] destination, int length)
        {
            return Array.Empty<int>();
        }
    }
}
