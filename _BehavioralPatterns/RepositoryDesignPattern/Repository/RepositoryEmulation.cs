using DesignPatternsTraining._BehavioralPatterns.RepositoryDesignPattern.Databases;
using System.Collections.Generic;

namespace DesignPatternsTraining._BehavioralPatterns.RepositoryDesignPattern.Repository
{
    public class RepositoryEmulation
    {
        public Contact GetContactById(long id)
        {
            return Contacts.GetContactDirectDbRequest(id);
        }
        
        public List<Contact> GetContacts()
        {
            return Contacts.GetContactsDirectDbRequest();
        }

        public void SaveContact(Contact contact)
        {
            Contacts.AddContactsDirectDbRequest(contact);
        }     
    }
}
