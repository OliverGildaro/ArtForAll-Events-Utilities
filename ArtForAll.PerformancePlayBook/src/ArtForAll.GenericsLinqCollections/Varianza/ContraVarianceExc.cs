using ArtForAll.GenericsLinqCollections.Varianza.Entities;
using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza
{
    internal class ContraVarianceExc
    {
        internal void Execute()
        {
            ISequence<IPerson> sequence = new MemorySequence<IPerson>();
            this.AddAuthor(sequence);
            this.AddPublisher(sequence);

            PrintSequence(sequence);
        }

        private void AddAuthor(ISequence<IPerson> sequence)
        {
            var controller = new AuthorController(sequence);
            controller.AddAuthor(new Author("Oliver"));
        }

        private void AddPublisher(ISequence<IPerson> sequence)
        {
            var controller = new PublisherController(sequence);
            controller.AddPublihser(new Publisher("Ivan"));
        }

        private static void PrintSequence(ISequenceReader<IPerson> sequence)
        {
            while (true)
            {
                var currentItem = sequence.GetNextItem();
                if (currentItem == null) break;
                Console.WriteLine(currentItem);
            }
        }
    }
}
