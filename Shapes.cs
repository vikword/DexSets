using System.Collections;

namespace DexSets
{
    class Shapes : IEnumerable, IEnumerator
    {
        readonly string[] shapes =
        {
            "Треугольник",
            "Квадрат",
            "Прямоугольник",
            "Ромб",
            "Многоугольник",
            "Круг",
            "Овал",
            "Трапеция",
            "Пароллелограмм"
        };

        int index = -1;

        public IEnumerator GetEnumerator()
        {
            return shapes.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (index == shapes.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return shapes[index];
            }
        }
    }
}