using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    class MyDateArray
    {
        public MyDateArray()
        {
            _currenDateTime = DateTime.Now;
        }

        private int _plusDay;
        private DateTime _currenDateTime;


        public string this[int index]
        {
            get
            {
                _plusDay = index;
                return GetDate().ToString("d");
            }
        }

        private DateTime GetDate()
        {
            return _currenDateTime.AddDays(_plusDay);
        }
    }
}
