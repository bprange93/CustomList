using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ThreePositiveValues_CountThree()
        {
            //arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 3;
            int actual;

            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList.count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_TwoPositiveVaule_CountOne()
        {
            //arrange
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 1;
            int actual;


            //act
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value3);
            actual = myList.count;

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_ToStringMethod()
        {
            //act
            MyList<int> myList = new MyList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            string expected = "1,2,3";
            string actual;

            //arrange
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = (value1.ToString() + "," + value2.ToString() + "," + value3.ToString());

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
