using System.Collections;

namespace DexSets
{
    class Autopark
    {
        readonly string[] _car =
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
            return _car.GetEnumerator();
        }
    }
}