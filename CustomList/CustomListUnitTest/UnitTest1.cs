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
    }
}
