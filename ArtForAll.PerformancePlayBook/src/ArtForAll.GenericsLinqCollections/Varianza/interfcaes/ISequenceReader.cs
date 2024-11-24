namespace ArtForAll.GenericsLinqCollections.Varianza.interfcaes
{
    public interface ISequenceReader<out T>
        where T : IPerson
    {
        T GetNextItem();
    }
}
