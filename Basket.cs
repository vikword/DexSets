using System.Collections;

namespace DexSets
{
    public class Basket : IEnumerable
    {
        readonly private Purchases[] _purchases;
        public Basket(Purchases[] purchasesArray)
        {
            _purchases = new Purchases[purchasesArray.Length];
            _purchases = purchasesArray;
        }

        IEnumerator IEnumerable.GetEnumerator()
    {
            return GetEnumerator();
        }

        public PurchasesEnum GetEnumerator()
        {
            return new PurchasesEnum(_purchases);
        }
    }
}