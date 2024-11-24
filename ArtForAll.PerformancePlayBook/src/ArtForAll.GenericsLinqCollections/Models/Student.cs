using ArtForAll.GenericsLinqCollections.abstracts;

namespace ArtForAll.GenericsLinqCollections.Models
{
    public class Student : Person, IComparable<Student>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1;
            if (other.LastName == LastName)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            return LastName.CompareTo(other.LastName);
        }
    }
}
