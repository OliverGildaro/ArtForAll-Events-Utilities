using ArtForAll.GenericsLinqCollections.reflection.interfaces;


namespace ArtForAll.GenericsLinqCollections.reflection
{
    public class Processor<T> : IProcessor<T>
    {
        public void Process(T input)
        {
            Console.WriteLine($"Generic Processor of T, processing {input}");
        }
    }
}
