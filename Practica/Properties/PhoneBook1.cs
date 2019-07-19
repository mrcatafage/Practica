using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Properties
{
    class PhoneBook
    {
        List<Contacts> contacts;

        public PhoneBook()
        {
            contacts = new List<Contacts>();
        }

        public void Add(string surname, string name, string patronymic, string number, string country, string birthday, string organization, string position, string other)
        {
            Contacts date = new Contacts(surname, name, patronymic, number, country, birthday, organization, position, other);
            contacts.Add(date);
        }

        public bool Remove(string name)
        {
            Contacts date = Find(name);

            if (date != null)
            {
                contacts.Remove(date);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void List(Action<Contacts> action)
        {
            contacts.ForEach(action);
        }

        public bool IsEmpty()
        {
            return (contacts.Count == 0);
        }
        public bool Find2(string name)
        {
            Contacts date = contacts.Find(
              delegate (Contacts a)
              {
                  return a.name == name;
              }
            );
            Contacts date1 = contacts.FindLast(
             delegate (Contacts a)
             {
                 return a.name == name;
             }
           );
            if (date1 == date)
                return true;
            else
                return false;
        }

        public Contacts Find(string name)
        {
            Contacts date = contacts.Find(
              delegate (Contacts a)
              {
                  return a.name == name;
              }
            );
            return date;
        }
        public Contacts Findtogether(string name, string surname)
        {
            Contacts date = contacts.Find(
              delegate (Contacts a)
              {
                  return (a.name == name && a.surname == surname);
              }
            );
            return date;
        }
    }
}
