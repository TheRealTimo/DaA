using System;
using DaA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaATests
{
    [TestClass]
    public class DoublyLinkedListTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            var list = new MyDoublyLinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(9);
            list.AddLast(1);
            list.AddLast(8);
            list.AddLast(3);

            list.BubbleSort(0, list.Count - 1);

            Assert.AreEqual("1, 2, 3, 5, 8, 9", list.ToString());
        }

        [TestMethod]
        public void TestBubbleSortPartialRange()
        {
            var list = new MyDoublyLinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(9);
            list.AddLast(1);
            list.AddLast(8);
            list.AddLast(3);

            list.BubbleSort(1, 4);

            Assert.AreEqual("5, 1, 2, 8, 9, 3", list.ToString());
        }

        [TestMethod]
        public void TestQuickSort()
        {
            var list = new MyDoublyLinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(9);
            list.AddLast(1);
            list.AddLast(8);
            list.AddLast(3);

            list.QuickSort(0, list.Count - 1);

            Assert.AreEqual("1, 2, 3, 5, 8, 9", list.ToString());
        }

        [TestMethod]
        public void TestQuickSortPartialRange()
        {
            var list = new MyDoublyLinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(9);
            list.AddLast(1);
            list.AddLast(8);
            list.AddLast(3);

            list.QuickSort(1, 4);

            Assert.AreEqual("5, 1, 2, 8, 9, 3", list.ToString());
        }

        [TestMethod]
        public void TestLinearSearch()
        {
            var list = new MyDoublyLinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(9);
            list.AddLast(1);
            list.AddLast(8);
            list.AddLast(3);

            Assert.IsTrue(list.LinearSearch(9, 0, list.Count - 1));
            Assert.IsFalse(list.LinearSearch(10, 0, list.Count - 1));
            Assert.IsFalse(list.LinearSearch(8, 0, 3));
        }

        [TestMethod]
        public void TestExponentialSearch_InBounds()
        {
            var list = new MyDoublyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(9);

            Assert.IsTrue(list.ExponentialSearch(5, 0, list.Count - 1));
            Assert.IsFalse(list.ExponentialSearch(5, 0, 2));
        }
    }

    [TestClass]
    public class MyStackTests
    {
        [TestMethod]
        public void TestLinearSearch()
        {
            var stack = new myStack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(3);

            Assert.IsTrue(stack.LinearSearch(9, 0, stack.Count - 1));
            Assert.IsFalse(stack.LinearSearch(10, 0, stack.Count - 1));
            Assert.IsTrue(stack.LinearSearch(8, 3, 5));
            Assert.IsFalse(stack.LinearSearch(8, 0, 2));
        }



        [TestMethod]
        public void TestExponentialSearch()
        {
            var stack = new myStack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(3);

            Assert.IsTrue(stack.ExponentialSearch(5, 0, stack.Count - 1));
            Assert.IsFalse(stack.ExponentialSearch(4, 0, stack.Count - 1));
            Assert.IsTrue(stack.ExponentialSearch(8, 3, 5));
            Assert.IsFalse(stack.ExponentialSearch(8, 0, 2));
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            var stack = new myStack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(3);

            stack.BubbleSort(0, stack.Count -1);

            Assert.AreEqual("1, 2, 3, 5, 8, 9", string.Join(", ", stack.GetItems()));
        }

        [TestMethod]
        public void TestBubbleSortPartialRange()
        {
            var stack = new myStack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(3);

            stack.BubbleSort(1, stack.Count - 1);

            Assert.AreEqual("5, 1, 2, 3, 8, 9", string.Join(", ", stack.GetItems()));
        }

        [TestMethod]
        public void TestQuickSort()
        {
            var stack = new myStack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(3);

            stack.QuickSort(0, stack.Count -1);

            Assert.AreEqual("1, 2, 3, 5, 8, 9", string.Join(", ", stack.GetItems()));
        }

        [TestMethod]
        public void TestQuickSortPartialRange()
        {
            var stack = new myStack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(3);

            stack.QuickSort(1, stack.Count - 1);

            Assert.AreEqual("5, 1, 2, 3, 8, 9", string.Join(", ", stack.GetItems()));
        }
    }
}
