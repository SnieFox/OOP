using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_3.Classes
{
    class CharArray : IntArray
    {
        public CharArray(int Length) : base(Length)
        {
            _array = new char[Length];
            resultLength = new int[2] { Length, base.ArrayLength };
        }

        private int _length;
        private protected char[] _array;
        private int[] resultLength;

        public new int[] ArrayLength
        {
            get
            {
                return resultLength;
            }
        }

        public char this[char index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
    }
}
