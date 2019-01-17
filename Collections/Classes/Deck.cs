using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] deckItems = new T[5];

        int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > deckItems.Length - 1)
            {
                Array.Resize(ref deckItems, deckItems.Length * 2);
            }

            deckItems[currentIndex] = item;

            currentIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return deckItems[i];
            }
        }

    }
}
