using System.Collections;
using System.Collections.Generic;

namespace UserCollection
{
    // Коллекция объектов типа string. Этот класс
    // реализует IEnumerable, чтобы его можно было использовать
    // с синтаксисом ForEach.
    class UserCollection<T> : IEnumerable
    {
        public List<T> ListCollection;

        public void Add(T value)
        {
            ListCollection.Add(value);
        }
        public void Remove()
        {
            if(ListCollection.Count > 5)
            {
                ListCollection.RemoveAt(ListCollection.Count-1);
            }
            
        }
        // Реализация для метода GetEnumerator.
        public IEnumerator GetEnumerator()
        {
            return new Iterator<T>(this);
        }
    }

    class Iterator<T> : IEnumerator
    {
        List<T> myListCollection;
        public Iterator(UserCollection<T> col)
        {
            myListCollection = col.ListCollection;
        }

        // Перечислители располагаются перед первым элементом
        // до первого вызова MoveNext ().
        int currentPosition = -1;

        public object Current
        {
            get
            {
                return myListCollection[currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (currentPosition < myListCollection.Count - 1)
            {
                currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }

    }
}
