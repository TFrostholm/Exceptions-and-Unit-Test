using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionsAndUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndUnitTest.Tests
{
    [TestClass()]
    public class BookTests
    {
        public Book TestBook = new Book();

        [TestMethod()]
        //Did know how to use : [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void SetTitleTest()
        {
            Exception caugthException = null;
            try
            {
                TestBook.SetTitle("a");
            }
            catch (Exception e)
            {
                e = caugthException;
            }

            Assert.IsNotNull(caugthException);

            // I give up...
        }
    }
}