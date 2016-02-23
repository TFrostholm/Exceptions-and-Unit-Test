using System;
using System.Security.AccessControl;

namespace ExceptionsAndUnitTest
{
    public class Book
    {
        private string _title;
        private int _year;


        //Title must be at least 2 characters long
        //Year must be between 1100 and 2015

        public void SetTitle(string title)
        {
            if (title.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }


        public void SetYear(int year)
        {
            if (year < 1100 || year > 2015)
            {
                throw new ArgumentOutOfRangeException();
            }
            _year = year;
        }

        public int GetYear()
        {
            return _year;
        }
    }
}