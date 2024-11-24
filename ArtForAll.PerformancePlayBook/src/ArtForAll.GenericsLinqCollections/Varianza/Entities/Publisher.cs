using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza.Entities;

public class Publisher : AggregateRoot, IPerson
{
    private int _id;
    private string _name;
    private string v;

    public Publisher(string name)
    {
        this._name = name;
        this._id = 2;
    }

    public int Id { get; }
    public string Name { get; }

    public void DoSomeWork()
    {
        Console.WriteLine("Publisher doing some work");
    }

    public void SayHello()
    {
        Console.WriteLine("Publisher say hello");
    }
}
