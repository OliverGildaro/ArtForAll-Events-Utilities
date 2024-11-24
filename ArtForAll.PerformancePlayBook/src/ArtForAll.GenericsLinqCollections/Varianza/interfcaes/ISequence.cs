namespace ArtForAll.GenericsLinqCollections.Varianza.interfcaes
{
    public interface ISequence<T> : ISequenceReader<T>, ISequenceWriter<T>
    where T : IPerson { }
}
