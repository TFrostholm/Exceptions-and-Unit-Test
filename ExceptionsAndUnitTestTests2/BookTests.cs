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
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetTitleTest()
        {
                //throw new ArgumentOutOfRangeException();
        }
    }
}