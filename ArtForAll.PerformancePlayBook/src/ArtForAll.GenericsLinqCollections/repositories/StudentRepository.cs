
using ArtForAll.GenericsLinqCollections.interfaces;
using ArtForAll.GenericsLinqCollections.Models;
using ArtForAll.Performance.GenericsLinQCollections.interfaces;

namespace ArtForAll.Performance.GenericsLinQCollections.repositories
{
    public class StudentRepository : IPersonRepository<Student>
    {
        private Name[] names= new Name[10];

        public StudentRepository()
        {
            names[0] = new ("Ivan", "Castro");
            names[1] = new ("Carolina", "Castro");
            names[2] = new ("Alvaro", "Castro");
            names[3] = new ("Cristian", "Morato");
            names[4] = new ("Oliver", "Castro");
            names[5] = new ("Amadeo", "Castro");
            names[6] = new ("Cristian", "Castro");
            names[7] = new ("Victor", "Morato");
            names[8] = new ("Karen", "Morato");
            names[9] = new ("Pamela", "Morato");
        }

        //We can use also IAsyncENumerable for better performance on I/O bound operations
        public IEnumerable<Student> IEnumerableList()
        {
            int index = 0;
            while (index < names.Length) 
            {
                yield return new Student(names[index].firstName, names[index].lastName);
                index++;
            }
        }

        public IEnumerable<Student> IEnumerableListOrdered()
        {
            var students = this.IEnumerableList().ToList();
            students.Sort();
            return students;
        }

        public Student[] List()
        {
            var students = new Student[10];

            students[0] = new Student("Ivan", "Castro");
            students[1] = new Student("Carolina", "Castro");
            students[2] = new Student("Alvaro", "Castro");
            students[3] = new Student("Cristian", "Morato");
            students[4] = new Student("Oliver", "Castro");
            students[5] = new Student("Amadeo", "Castro");
            students[6] = new Student("Cristian", "Castro");
            students[7] = new Student("Victor", "Morato");
            students[8] = new Student("Karen", "Morato");
            students[9] = new Student("Pamela", "Morato");

            Array.Sort(students);//implement IComparable to sort
            return students;
        }

        public IEnumerable<Student> Search(string byText)
        {
            return this.IEnumerableListOrdered()
                .Where(item => item.FirstName.Contains(byText) ||
                item.LastName.Contains(byText));
        }
    }
}
