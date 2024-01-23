using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person(2, "Joe", "Smith"));
            people.Add(new Person(163, "Joe", "Casey"));
            people.Add(new Person(123, "Sam", "Harris"));
            people.Add(new Person(3, "Ryan", "Early"));
            people.Add(new Person(143, "Bill", "Johnson"));

            people.Where(Person => Person.FirstName == "Joe"); //finds Jos
            people.Where(Person => Person.Id > 5) //finds with people with an id greater than 5
                .ToList()
                .ForEach(Person => Console.WriteLine(Person.FirstName + " " + Person.LastName + " " + Person.Id));

          
              


            // -- usinig foreach loop to find joe's --
            //foreach (Person person in people)
            //{
            //    if (person.FirstName == "Joe")
            //    {
            //        Console.WriteLine(person.FirstName + " "+  person.LastName + " " +  person.Id);  
            //    }              
            //}

            Console.Read(); 
        }
    }
}
