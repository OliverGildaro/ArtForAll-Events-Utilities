using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void DoSomeWork()
        {
            throw new NotImplementedException();
        }

        public void SayHello()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
