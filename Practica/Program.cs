using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Properties;

namespace Practica
{
        class Notes
        {
            PhoneBook book;

            public Notes()
            {
                book = new PhoneBook();
            }

            static void Main(string[] args)
            {
                string select = "";
                Notes note = new Notes();

                note.Menu();
                while (!select.Equals("5"))
                {
                    Console.WriteLine("Выберите: ");
                    select = Console.ReadLine();
                    note.ChooseAction(select);
                }
            }

            void Menu()
            {
                Console.WriteLine("0) Добавить контакт");
                Console.WriteLine("1) Изменить контакт");
                Console.WriteLine("2) Удалить контакт");
                Console.WriteLine("3) Найти контакт");
                Console.WriteLine("4) Вывести список контактов");
                Console.WriteLine("5) Выйти");
            }

            void ChooseAction(string select)
            {
                string surname = "";
                string name = "";
                string patronymic = "";
                string number = "";
                string country = "";
                string birthday = "";
                string organization = "";
                string position = "";
                string other = "";

                switch (select)
                {
                    case "0":
                        while (name == "")
                        {
                            Console.WriteLine("Введите Имя:");
                            name = Console.ReadLine();
                        }
                        while (surname == "")
                        {
                         Console.WriteLine("Введите Фамилию: ");
                        surname = Console.ReadLine();
                        }
                        Console.WriteLine("Введите Отчество: ");

                        patronymic = Console.ReadLine();
                        Console.WriteLine("Введите Номер: ");
                        long result;
                        number = Console.ReadLine();
                        while (number == "")
                        {
                            Console.WriteLine("Внимание!!! Введите Номер!");
                            number = Console.ReadLine();
                        }
                        result = Convert.ToInt64(number);
                        while (country == "")
                        {                       
                        Console.WriteLine("Введите Страну проживания: ");
                        country = Console.ReadLine();
                        }
                        Console.WriteLine("Введите Дату рождения: ");
                        birthday = Console.ReadLine();
                        Console.WriteLine("Введите Организацию: ");
                        organization = Console.ReadLine();
                        Console.WriteLine("Введите должность: ");
                        position = Console.ReadLine();
                        Console.WriteLine("Введите Прочая информация: ");
                        other = Console.ReadLine();
                        book.Add(surname, name, patronymic, number, country, birthday, organization, position, other);
                        break;
                     case "1":
                        Console.WriteLine("Введите Имя для изменения: ");
                        name = Console.ReadLine();
                        Contacts date;
                        if (book.Find2(name))
                            date = book.Find(name);
                        else
                        {
                            Console.WriteLine("Введите Фамилию для изменения: ");
                            surname = Console.ReadLine();
                            date = book.Findtogether(name, surname);
                        }

                        if (date == null)
                        {
                            Console.WriteLine("Контакт с именем {0} не найден. Нажмите кнопку для продолжения.", name);
                            Console.ReadKey();
                        }
                        else
                        {
                            string edition = "";
                            Notes edit = new Notes();
                            Console.WriteLine("Введите что вы меняете(на английском): ");
                            edition = Console.ReadLine();
                            edit.ChooseAction(edition);
                            switch (edition)
                            {
                                case "surname":
                                    Console.WriteLine("Введите Фамилию: ");
                                    date.surname = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "name":
                                    Console.WriteLine("Введите Имя: ");
                                    date.name = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "patronymic":
                                    Console.WriteLine("Введите Отчество: ");
                                    date.patronymic = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "number":
                                    Console.WriteLine("Введите Номер: ");
                                    date.number = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "country":
                                    Console.WriteLine("Введите Страну проживания: ");
                                    date.country = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "birthday":
                                    Console.WriteLine("Введите  День рождения: ");
                                    date.birthday = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "organization":
                                    Console.WriteLine("Введите Организацию: ");
                                    date.organization = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "position":
                                    Console.WriteLine("Введите Должность: ");
                                    date.position = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                                case "other":
                                    Console.WriteLine("Введите Прочую информацию: ");
                                    date.other = Console.ReadLine();
                                    Console.WriteLine("Обновлены данные для {0}", name);
                                    break;
                            }
                        }
                        break;
                     case "2":
                        Console.WriteLine("Введите Имя удаляемого контакта: ");
                        name = Console.ReadLine();
                        if (book.Remove(name))
                        {
                            Console.WriteLine("Контакт удален");
                        }
                        else
                        {
                            Console.WriteLine("Контакт с именем {0} не найден. Нажмите кнопку для продолжения.", name);
                            Console.ReadKey();
                        }
                        break;            
                    case "3":
                        Console.WriteLine("Введите Имя: ");
                        name = Console.ReadLine();
                        Contacts find;
                        if (book.Find2(name))
                            find = book.Find(name);
                        else
                        {
                            Console.WriteLine("Введите Фамилию: ");
                            surname = Console.ReadLine();
                            find = book.Findtogether(name, surname);
                        }
                        if (find == null)
                        {
                            Console.WriteLine("Контакт с именем {0} не найден. Нажмите кнопку для продолжения.", name);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Contact:");
                            Console.WriteLine("Фамилию:{0}, Имя:{1}, Отчество:{2}, Номер телефона:{3}, Страна:{4}, Дата рождения:{5}, Организация:{6}, Должность:{7}, Другое:{8}"
                                , find.surname, find.name, find.patronymic, find.number, find.country, find.birthday, find.organization, find.position, find.other);
                        }
                        break;
                    case "4":
                        if (book.IsEmpty())
                        {
                            Console.WriteLine("Записная книжка пуста.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Контакты:");
                            book.List(
                              delegate (Contacts a)
                              {
                                  Console.WriteLine("{0} - {1} - {2}", a.surname, a.name, a.number);
                              }
                            );
                        }
                        break;       
                }
            }
        }
    }
