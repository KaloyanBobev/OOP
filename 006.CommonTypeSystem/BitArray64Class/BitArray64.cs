using System;
using System.Collections;
using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>
    {
        //field
        private ulong number;

        //property
        public ulong Number
        {
            get { return this.number; }
            set { this.Number = value; }
        }

        //constructor
        public BitArray64(ulong number)
        {
            this.number = number;
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        
        public int[] Bits
        {
            get { return this.ConvertToBits(); }
        }

       
        private int[] ConvertToBits()
        {
            ulong value = this.number;

            int[] bits = new int[64];
            int count = 63;

            while (value != 0)
            {
                bits[count] = (int)value % 2;
                value /= 2;
                count--;
            }

            do
            {
                bits[count] = 0;
                count--;
            }
            while (count != 0);

            return bits;
        }

        
        public bool Equals(object value)
        {
            BitArray64 bit = value as BitArray64;
            if (bit == null)
            {
                return false;
            }
            if (!Object.Equals(this.number,bit.number))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return number.GetHashCode() ^ number.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

       
        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(BitArray64.Equals(first, second));
        }
    }

