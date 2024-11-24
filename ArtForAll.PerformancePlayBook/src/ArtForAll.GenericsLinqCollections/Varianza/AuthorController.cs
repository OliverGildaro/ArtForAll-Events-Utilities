using ArtForAll.GenericsLinqCollections.Varianza.Entities;
using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza;

public class AuthorController
{
    private readonly ISequence<IPerson> sequence;

    public AuthorController(ISequence<IPerson> sequence)
    {
        this.sequence = sequence;
    }

    public void AddAuthor(Author Author)
    {
        this.sequence.Add(Author);
    }
}
