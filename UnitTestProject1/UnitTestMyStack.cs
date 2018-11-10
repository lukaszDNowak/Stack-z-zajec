using System;
using stack;
using NUnit.Framework;

namespace StackTest
{

    public class StackUnitTest
    {
        [Test]
        public void TestPush()
        {
            Stack<int> st = new Stack<int>();
            st.Push(200);

            Assert.AreEqual(st.Pop(), 200);
        }
        [Test]
        public void TestPop()
        {
            Stack<string> st = new Stack<string>();
            st.Push("S");
            st.Push("T");
            st.Push("A");
            
            Assert.AreEqual(st.Pop(), "A");
            Assert.AreEqual(st.Pop(), "T");
            Assert.AreEqual(st.Pop(), "S");
        }

        [Test]
        public void TestPopExeption()
        {
            Stack<object> st = new Stack<object>();
            Assert.That(() => st.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void TestPeekExeption()
        {
            Stack<object> st = new Stack<object>();
            Assert.That(() => st.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void TestPushExeption()
        {
            Stack<object> st = new Stack<object>();
            Assert.That(() => st.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void TestPeek()
        {
            Stack<string> st = new Stack<string>();
            st.Push("S");
            st.Push("T");
            st.Push("A");

            Assert.AreSame(st.Peek(), "A");
        }

        [Test]
        public void StackIsEmpty()
        {
            Stack<string> st = new Stack<string>();

            Assert.AreEqual(st.Count, 0);
        }
        [Test]
        public void StackIsNotEmpty()
        {
            Stack<object> st = new Stack<object>();
            st.Push("Nie jest pusty");
            Assert.AreEqual(st.Count, 1);
        }
    }
}
