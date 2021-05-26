using System;
using System.Collections;


namespace DexSets
{
    public class PurchasesEnum : IEnumerator
    {
        public Purchases[] Purchases { get; set; }

        int _position = -1;

        public PurchasesEnum(Purchases[] list)
        {
            Purchases = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < Purchases.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Purchases Current
        {
            get
            {
                try
                {
                    return Purchases[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}