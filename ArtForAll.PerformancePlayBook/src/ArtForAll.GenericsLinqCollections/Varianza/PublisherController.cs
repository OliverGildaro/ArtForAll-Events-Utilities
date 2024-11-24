using ArtForAll.GenericsLinqCollections.Varianza.Entities;
using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza;

public class PublisherController
{
    private readonly ISequence<IPerson> sequence;

    public PublisherController(ISequence<IPerson> sequence)
    {
        this.sequence = sequence;
    }

    public void AddPublihser(Publisher publisher)
    {
        this.sequence.Add(publisher);
    }
}
