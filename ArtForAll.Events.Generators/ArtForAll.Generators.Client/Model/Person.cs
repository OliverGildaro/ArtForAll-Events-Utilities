namespace ArtForAll.Generators.Client.Model
{
    using ArtForAll.Generators;

    [GenerateToString]
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
