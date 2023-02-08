using System;
using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Wintellect.PowerCollections.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod] 
        public void Capacity() // должен быть равен размеру стека который вводится в конструктор
        {
            Stack<int> a=new Stack<int>(5);
            Assert.AreEqual(5, a.Capacity);
        }

        [TestMethod]
        public void Count() // должен быть  больше 0, если стек заполнен(должен равен количеству запушенных элементов) 
        {
            Stack<int> a = new Stack<int>(5);
            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);
            a.Push(5);
            Assert.AreEqual(5, a.Count);
        }

        [TestMethod]
        public void Push_Test_Positive_Work() //проверка работы пуш при обычной работе
        {
            Stack<int> a = new Stack<int>(8);
            a.Push(1);
            a.Push(3);
            a.Push(8);
            Assert.AreEqual(8, a.Top());
            Assert.AreEqual(3, a.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Push_Test_Throws_Exception_When_Stack_OverFlow() //проверка при переполнении стека при работу пуш
        {
            Stack<int> a = new Stack<int>(3);
            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);

        }

        [TestMethod]
        public void Constructor_With_Parameter() // работа конструктора с параметрами
        {
            Stack<int> a = new Stack<int>(5234);
            Assert.AreEqual(5234, a.Capacity);
        }
        [TestMethod]
        public void Constructor_WithOut_Parameter() // работа конструктора без параметров
        {
            Stack<int> a = new Stack<int>();
            Assert.AreEqual(1, a.Capacity);
        }

        [TestMethod]
        public void Constructor_With_Negative_Parameter() // работа конструктора с отрицательным параметром
        {
            try 
            {
                Stack<int> a = new Stack<int>(-1);
            }

            catch(InvalidOperationException e) 
            {
                Assert.AreEqual("Размер стека не может быть отрицателен", e.Message);
            }
        }

        [TestMethod]
        public void Pop_Positive_Work() //проверка при обычной работе метода Pop
        {
            Stack<int> a = new Stack<int>(10);
            a.Push(1);
            a.Push(2);

            Assert.AreEqual(2, a.Count);
            Assert.AreEqual(2, a.Pop());
            Assert.AreEqual(1, a.Pop());
            Assert.AreEqual(0, a.Count);
        }

        [TestMethod]
        public void Pop_Throws_Exception_When_Stack_IsEmpty() //проверка при пустом стеке метода Pop 

        {
            
                
            Stack<int> a = new Stack<int>(10);
            try
            {
                a.Pop();
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("Стек не имеет значений", e.Message);
            }

        }

        [TestMethod]
        public void Top_Positive_Work()//проверка при обычной работе методе Top
        {
            Stack<int> a = new Stack<int>(10);
            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);
            a.Push(5);

            Assert.AreEqual(5, a.Count);
            Assert.AreEqual(5, a.Top());
            Assert.AreEqual(5, a.Count);
        }

        [TestMethod]
        public void Top_Throws_Exception_When_Stack_IsEmpty()//проверка при пустом стеке метода Top
        {


            Stack<int> a = new Stack<int>(10);
            try
            {
                a.Top();
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("Стек не имеет значений", e.Message);
            }

        }

        [TestMethod]
        public void Enumerator_Work() // должен возвращать перевёрнутый массив запушенных элементов
        {
            Stack<char> num=new Stack<char>(9);
            char[] x = new char[]
            {
                '9','y','6','c','i'
            };
            for (int i = 0; i < x.Length; i++)
            {
                num.Push(x[i]);
            }
            var q = from w in num select w;
            q = q.Reverse();
            CollectionAssert.AreEqual(x, q.ToArray());
        }



        [TestMethod]
        public void StackConstructor_WithParameters_Test() // Проверка работы конструктора при передаче параметров
        {
            Stack<bool> tests = new Stack<bool>(100);

            Assert.AreEqual(100, tests.Capacity); // Проверка того, что размер стека равен параметру
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StackConstructor_WithNegativeParameters_Test() // Проверка работы конструктора при передаче в него отрицательного значения
        {
            Stack<int> tests2 = new Stack<int>(-1);
        }
    }
}
