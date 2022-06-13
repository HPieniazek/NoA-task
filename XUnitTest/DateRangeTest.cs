using NoA_task;
using System;
using System.Globalization;
using Xunit;

namespace NoA_task.Tests
{
    public class DateRangeTest
    {
        [Theory]
        [InlineData("01/01/1111", "02/01/1111")]
        [InlineData("01-01-1111", "02-01-1111")]
        [InlineData("01.01.1111", "02.01.1111")]
        public void DiffDaysConvertToExpectedFormat_DateFormatting_ReturnsDateRangeToString(string start, string end)
        {
            var culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            DateTime Start = DateTime.Parse(start);
            DateTime End = DateTime.Parse(end);

            string expected = $"{Start.ToString("dd")} - {End.Date.ToString("d")}";

           
            
            DateRange range = new(Start, End);
            
            string actual = range.DateFormating();
            
             Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("01/01/1111", "02/02/1111")]
        [InlineData("01-01-1111", "02-02-1111")]
        [InlineData("01.01.1111", "02.02.1111")]
        public void DiffMonthsConvertToExpectedFormat_DateFormatting_ReturnsDateRangeToString(string start, string end)
        {
            var culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            DateTime Start = DateTime.Parse(start);
            DateTime End = DateTime.Parse(end);

            string expected = $"{Start.ToString("dd/MM")} - {End.Date.ToString("d")}";

            DateRange range = new(Start, End);

            string actual = range.DateFormating();

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("2016/01/01", "2017/01/02")]
        [InlineData("2016.01.01", "2017.01.02")]
        [InlineData("2016-01-01", "2017-01-02")]
        [InlineData("2016/02/01", "2017/02/02")]
        [InlineData("2016.02.01", "2017.02.02")]
        [InlineData("2016-02-01", "2017-02-02")]

        public void FirstYearConvertToExpectedFormat_DateFormatting_ReturnsDateRangeToString(string start, string end)
        {
            var culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            DateTime Start = DateTime.Parse(start);
            DateTime End = DateTime.Parse(end);

            string expected = $"{Start.ToString("yyyy/MM/dd")} - {End.Date.ToString("yyyy/MM/dd")}";

            DateRange range = new(Start, End);

            string actual = range.DateFormatingYearFirst();

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("2017/02/01", "2016/02/02")]
        [InlineData("2017.02.01", "2016.02.02")]
        [InlineData("2017-02-01", "2016-02-02")]
        public void FirstYearStartBigger_ConvertToExpectedFormat_DateFormatting_ReturnsDateRangeToString(string start, string end)
        {
            var culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            DateTime Start = DateTime.Parse(start);
            DateTime End = DateTime.Parse(end);

            string expected = $"{End.ToString("yyyy/MM/dd")} - {Start.Date.ToString("yyyy/MM/dd")}";

            DateRange range = new(Start, End);

            string actual = range.DateFormatingYearFirst();

            Assert.Equal(expected, actual);
        }
    }
}
