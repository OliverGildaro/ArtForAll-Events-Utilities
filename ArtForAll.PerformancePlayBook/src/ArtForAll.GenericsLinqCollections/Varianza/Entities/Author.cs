using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza.Entities;

public class Author : AggregateRoot, IPerson
{
    private readonly int _id;
    private readonly string _name;
    private string v;

    public Author(string name)
    {
        this._name = name;
        this._id = 1;
    }

    public int Id => this._id;
    public string Name => this._name;

    public void DoSomeWork()
    {
        Console.WriteLine("Author doing some work");
    }

    public void SayHello()
    {
        Console.WriteLine("Author say hello");
    }
}
