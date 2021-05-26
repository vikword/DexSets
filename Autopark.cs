using System.Collections;

namespace DexSets
{
    class Autopark : IEnumerable
    {
        readonly string[] car =
        {   "Audi",
            "BMW",
            "Chevrolet",
            "Citroen",
            "Ford",
            "Honda",
            "Hyundai",
            "Infiniti",
            "KIA",
            "Lada",
            "Land Rover",
            "Lexus",
            "Mazda",
            "Mercedes - Benz"
        };

        public IEnumerator GetEnumerator()
        {
            return car.GetEnumerator();
        }
    }
}