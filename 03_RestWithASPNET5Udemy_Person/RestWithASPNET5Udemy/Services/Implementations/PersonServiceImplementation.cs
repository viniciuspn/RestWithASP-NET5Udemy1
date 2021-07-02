
using RestWithASPNET5Udemy.Model;
using System.Collections.Generic;
using System.Threading;


namespace RestWithASPNET5Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;//variavel para criar um id novo

        public Person Create(Person person)
        {
            return person;
        }

        public Person FindByID(long id)
        {
           return new Person
           {
               Id =  1,
               FirstName = "Vinicius",
               LastName = "Nogueira",
               Address = "Rua Luiz da Penha - Minas Gerais - Brasil",
               Gender = "Male"
           };
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person Update(Person person)
        {

            return person;
        }

        public void Delete(long id)
        {
           
        }

        private Person MockPerson(int i)
        {
            return new Person
           {
               Id =  IncrementAndGet(),
               FirstName = "Person Name" + i,
               LastName = "Person LastName" + i,
               Address = "Some Addres" + i,
               Gender = "Male"
           };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}