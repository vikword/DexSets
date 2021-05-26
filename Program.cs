using System;

namespace DexSets
{
    class Program
    {
        static void Main()
        {
            //Автопарк
            var car = new Autopark();

            foreach (string i in car)
                Console.WriteLine(i);
            Console.WriteLine();

            //Корзина
            var purchasesArray = new Purchases[5]
            {
            new Purchases("Хлеб"),
            new Purchases("Молоко"),
            new Purchases("Сыр"),
            new Purchases("Манго"),
            new Purchases("Вода")
            };

            var purchasesList = new Basket(purchasesArray);
            foreach (var p in purchasesList)
                Console.WriteLine(p.PurchasesName);
            Console.WriteLine();

            //Фигуры
            var shapes = new Shapes();

            while (shapes.MoveNext())
            {
                var item = (string)shapes.Current;
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}