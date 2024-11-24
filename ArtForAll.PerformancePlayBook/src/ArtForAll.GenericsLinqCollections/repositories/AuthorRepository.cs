using ArtForAll.GenericsLinqCollections.Models;
using ArtForAll.Performance.GenericsLinQCollections.interfaces;

namespace ArtForAll.Performance.GenericsLinQCollections.repositories
{
    public class AuthorRepository : IRepository<Author>
    {
        private IRepository<Student> studentsRepo = new StudentRepository();

        public IEnumerable<Author> IEnumerableList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> IEnumerableListOrdered()
        {
            throw new NotImplementedException();
        }

        public Author[] List()
        {
            var authors = new Author[10];
            int i = 0;
            foreach (Student student in studentsRepo.List())
            {
                authors[i] = new Author(student.FirstName, student.LastName);
                i++;
            }

            Array.Sort(authors);
            return authors;
        }
    }
}
