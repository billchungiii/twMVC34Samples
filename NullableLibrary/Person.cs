using System;

namespace NullableLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
