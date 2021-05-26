using System.Collections;


namespace DexSets
{
    public class Purchases : IEnumerable
    {
        private Basket[] purchases;
        public Purchases(Basket[] pArray)
        {
            purchases = new Basket[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                purchases[i] = pArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public PurchasesEnum GetEnumerator()
        {
            return new PurchasesEnum(purchases);
        }
    }
}