using Newtonsoft.Json;
using System;

namespace MyOwnProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Bogdan",
                LastName = "Kozak",
                Age = 19
            };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(json);

            Console.WriteLine("\nDeserialized Person:");
            Console.WriteLine($"First Name: {deserializedPerson.FirstName}");
            Console.WriteLine($"Last Name: {deserializedPerson.LastName}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
