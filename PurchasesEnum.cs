using System;
using System.Collections;


namespace DexSets
{
    public class PurchasesEnum : IEnumerator
    {
        readonly private Purchases[] _purchases;

        int _position = -1;

        public PurchasesEnum(Purchases[] list)
        {
            _purchases = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _purchases.Length);
        }

        public void Reset()
        {
            _position = -1;
        }
        
        object IEnumerator.Current { get; }
        
        public Purchases Current
        {
            get
            {
                try
                {
                    return _purchases[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}