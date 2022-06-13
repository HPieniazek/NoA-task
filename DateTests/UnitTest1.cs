using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoA_task;
using System;

namespace DateTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Day_Diff_Date_Value()
        {
            DateTime start = new(1111,1,1);
            DateTime end = new(1111,1,2);
            string expected = "01 - 02.01.1111";
            DateRange range = new(start, end);
            string actual = range.DateFormating();
            Assert.AreEqual(expected,range);
        }
        
    }
}
