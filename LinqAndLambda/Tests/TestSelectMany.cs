using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestSelectMany : ITest
    {
        public void Test()
        {
            var persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Name = "John",
                PersonPhones = new List<PersonPhone>() {
                    new PersonPhone { PersonNumber = "123456"},
                    new PersonPhone { PersonNumber = "654321"},
                }
            });

            persons.Add(new Person
            {
                Id = 2,
                Name = "Mary",
                PersonPhones = new List<PersonPhone>() {
                    new PersonPhone { PersonNumber = "54644"},
                    new PersonPhone { PersonNumber = "78545"},
                }
            });

            //Pegar todos os telefones idependente de que é. 
            var personPhones = persons.Select(person => person.PersonPhones); //<List><List>

            foreach (var personPhone in personPhones)
            {
                foreach (var phone in personPhone)
                {
                    Console.WriteLine("Using Select" + phone.PersonNumber);
                }
            }

            //Pega list de list sem usar um foreach dentro de um foreach
            var phones = persons.SelectMany(person => person.PersonPhones);

            foreach (var phone in phones)
            {
                Console.WriteLine("Using SelectMany" + phone.PersonNumber);
            }

        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<PersonPhone> PersonPhones { get; set; }
        }

        class PersonPhone
        {
            public string PersonNumber { get; set; }
        }
    }
}
