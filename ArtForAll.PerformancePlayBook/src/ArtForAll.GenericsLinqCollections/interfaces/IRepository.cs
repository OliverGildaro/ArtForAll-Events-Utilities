using ArtForAll.GenericsLinqCollections.abstracts;

namespace ArtForAll.Performance.GenericsLinQCollections.interfaces
{
    public interface IRepository<T>
        where T : IComparable<T>
    {
        T[] List();
        IEnumerable<T> IEnumerableList();
        IEnumerable<T> IEnumerableListOrdered();
    }

}
