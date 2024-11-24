using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza
{
    public class MemorySequence<T> : ISequence<T>
        where T : IPerson
    {
        private Queue<T> _queue = new Queue<T>();

        public void Add(T item)
        {
            _queue.Enqueue(item);
        }

        public T GetNextItem()
        {
            if (_queue.Count == 0) return default(T);
            return _queue.Dequeue();
        }
    }
}
