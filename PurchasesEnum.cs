using System;
using System.Collections;


namespace DexSets
{
    public class PurchasesEnum : IEnumerator
    {
        public Basket[] purchases;

        int position = -1;

        public PurchasesEnum(Basket[] list)
        {
            purchases = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < purchases.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Basket Current
        {
            get
            {
                try
                {
                    return purchases[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}