using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Properties
{
    class Contacts
    {
        public string surname;
        public string name;
        public string patronymic;
        public string number;
        public string country;
        public string birthday;
        public string organization;
        public string position;
        public string other;

        public Contacts(string surname, string name, string patronymic, string number, string country, string birthday, string organization, string position, string other)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.number = number;
            this.country = country;
            this.birthday = birthday;
            this.organization = organization;
            this.position = position;
            this.other = other;
        }
    }
}
