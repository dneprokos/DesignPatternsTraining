using System;

namespace DesignPatternsTraining._CreationalPatterns.PrototypeDesignPattern.PrototypeInTesting
{
    public class Person : IPersonPrototype
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public void ShowUserDetails()
        {
            Console.WriteLine("######Showing user info######");
            if (FirstName != null) Console.WriteLine("First Name: " + FirstName);
            if (LastName != null) Console.WriteLine("Last Name: " + LastName);
            if (DateOfBirth != null) Console.WriteLine("DOB: " + DateOfBirth.Date);
        }

        public IPersonPrototype Clone()
        {
            return (IPersonPrototype)this.MemberwiseClone();
            //return new Person(this); JAVA EXAMPLE
        }
    }
}
