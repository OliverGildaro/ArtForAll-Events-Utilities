using ArtForAll.GenericsLinqCollections.abstracts;

namespace ArtForAll.GenericsLinqCollections.Models
{
    public class Author : Person, IComparable<Author>
    {
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public int CompareTo(Author? other)
        {
            if (other == null) return 1;
            return ToString().CompareTo(other.ToString());
        }
    }
}
