using System.Collections;

namespace DexSets
{
    class Shapes : IEnumerable, IEnumerator
    {
        readonly string[] _shapes =
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

        int _index = -1;

        public IEnumerator GetEnumerator()
        {
            return _shapes.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (_index == _shapes.Length - 1)
            {
                Reset();
                return false;
            }

            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }

        public object Current
        {
            get
            {
                return _shapes[_index];
            }
        }
    }
}