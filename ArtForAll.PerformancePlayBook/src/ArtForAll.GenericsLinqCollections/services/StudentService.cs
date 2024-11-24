using ArtForAll.GenericsLinqCollections.interfaces;
using ArtForAll.GenericsLinqCollections.Models;
using ArtForAll.Performance.GenericsLinQCollections.interfaces;
using ArtForAll.Performance.GenericsLinQCollections.repositories;

namespace ArtForAll.Performance.GenericsLinQCollections.services
{
    public class StudentService
    {
        private readonly IPersonRepository<Student> repository;

        public StudentService(IPersonRepository<Student> repository)
        {
            this.repository = repository;
        }


        public void PrintStudents(int max = 100)
        {
            var studentRepo = new StudentRepository();
            var students = studentRepo.IEnumerableListOrdered()
                .Take(max);
                //.ToArray();//Will add extra allocation of the collection

            //Array.Sort(students);

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            this.PrintStudentsTOCOnsole(students);
        }

        public void PrintStudentsSearch(string byText)
        {
            PrintStudentsTOCOnsole(this.repository.Search(byText));
        }

        private void PrintStudentsTOCOnsole(IEnumerable<Student> students)
        {
            //Since IEnumerable implements foreach we can iterate
            //And using yied keyword we can bring one student at each time
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
