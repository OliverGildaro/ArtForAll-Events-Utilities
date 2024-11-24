using ArtForAll.GenericsLinqCollections.reflection.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtForAll.GenericsLinqCollections.reflection
{
    public class CustomerProcessor : IProcessor<Customer>, ILogger
    {
        public void Process(Customer input)
        {
            Console.WriteLine($"Processing Customer: {input}");
        }

        public static void ExpediteProcess<TExpedited>(TExpedited input)
        {
            Console.WriteLine($">>> EXPEDITE! {input}");
        }

        public void Log<T>(T input)
        {
            Console.WriteLine($"Logging Generic Type: {input}");
        }
    }
}
