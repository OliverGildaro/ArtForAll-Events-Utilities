using ArtForAll.GenericsLinqCollections.abstracts;
using ArtForAll.Performance.GenericsLinQCollections.interfaces;

namespace ArtForAll.GenericsLinqCollections.interfaces
{
    //This is the interface segregation principle
    public interface IPersonRepository<T> : IRepository<T>
        where T : Person, IComparable<T>
        
    {
        IEnumerable<T> Search(string byText);
    }
}
