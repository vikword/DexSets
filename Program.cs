using System;

namespace DexSets
{
    class Program
    {
        static void Main()
        {
            //Автопарк
            Autopark car = new Autopark();

            foreach (string i in car)
                Console.WriteLine(i);
            Console.WriteLine();

            //Корзина
            Basket[] purchasesArray = new Basket[5]
            {
            new Basket("Хлеб"),
            new Basket("Молоко"),
            new Basket("Сыр"),
            new Basket("Манго"),
            new Basket("Вода")
            };

            Purchases purchasesList = new Purchases(purchasesArray);
            foreach (Basket p in purchasesList)
                Console.WriteLine(p.PurchasesName);
            Console.WriteLine();

            //Фигуры
            Shapes shapes = new Shapes();

            while (shapes.MoveNext())
            {
                string item = (string)shapes.Current;
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}