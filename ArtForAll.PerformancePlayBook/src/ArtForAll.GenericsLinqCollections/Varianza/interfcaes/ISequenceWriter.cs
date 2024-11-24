namespace ArtForAll.GenericsLinqCollections.Varianza.interfcaes
{
    public interface ISequenceWriter<in T>
        where T : IPerson
    {
        void Add(T item);
    }
}
