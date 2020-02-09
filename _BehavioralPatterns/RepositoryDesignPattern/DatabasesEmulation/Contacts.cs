using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsTraining._BehavioralPatterns.RepositoryDesignPattern.Databases
{
    /// <summary>
    /// This is just for example. In real world in could be real SQL or NoSQL database
    /// </summary>
    public static class Contacts
    {
        private static List<Contact> contacts = new List<Contact>();

        public static List<Contact> GetContactsDirectDbRequest()
        {
            return contacts;
        }

        public static void AddContactsDirectDbRequest(Contact contact)
        {
            Contact isIdExist = contacts.FirstOrDefault(c => c.Id.Equals(contact.Id));

            if (isIdExist == null)
            {
                contacts.Add(contact);
                Console.WriteLine("Contact was added with Id equals to: " + contact.Id);
            }
            else
            {
                Console.WriteLine("Contact with ID: " + contact.Id + " already exists. Please select another one ID");
            } 
        }

        public static Contact GetContactDirectDbRequest(long id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id.Equals(id));

            return contact == null ? null : contact; 
        }

    }

    public class Contact
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public void ShowContactData()
        {
            Console.WriteLine("Contact data: Id = " + Id + " Name = " + Name + " Email = " + Email);
        }

        public Contact SetId(long id)
        {
            Id = id;
            return this;
        }

        public Contact SetName(string name)
        {
            Name = name;
            return this;
        }

        public Contact SetEmail(string email)
        {
            Email = email;
            return this;
        }
    }
}
