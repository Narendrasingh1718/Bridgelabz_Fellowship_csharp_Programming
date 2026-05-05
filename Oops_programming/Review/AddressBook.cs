using System;

namespace Review
{

    internal class AddressBook
    {
        public string FirstName;
        public string LastName;
        public string City;
        public string Phone;

        public AddressBook(string firstName, string lastName, string city, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Phone = phone;
        }

        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} | {City} | {Phone}");
        }
    }


    internal class AddressBook
    {
        private AddressBook[] people = new AddressBook[100];
        private int count = 0;


        public void AddPerson(AddressBook p)
        {

            for (int i = 0; i < count; i++)
            {
                if (people[i].FirstName == p.FirstName &&
                    people[i].LastName == p.LastName)
                {
                    Console.WriteLine("Duplicate Entry!");
                    return;
                }
            }

            if (count < people.Length)
            {
                people[count] = p;
                count++;
                Console.WriteLine("Person Added.");
            }
            else
            {
                Console.WriteLine("Address Book Full!");
            }
        }


        public void DisplayAll()
        {
            for (int i = 0; i < count; i++)
            {
                people[i].Display();
            }
        }


        public void EditPerson(string firstName)
        {
            for (int i = 0; i < count; i++)
            {
                if (people[i].FirstName == firstName)
                {
                    Console.Write("New City: ");
                    people[i].City = Console.ReadLine();

                    Console.Write("New Phone: ");
                    people[i].Phone = Console.ReadLine();

                    Console.WriteLine("Updated.");
                    return;
                }
            }

            Console.WriteLine("Not Found.");
        }


        public void DeletePerson(string firstName)
        {
            for (int i = 0; i < count; i++)
            {
                if (people[i].FirstName == firstName)
                {

                    for (int j = i; j < count - 1; j++)
                    {
                        people[j] = people[j + 1];
                    }

                    count--;
                    Console.WriteLine("Deleted.");
                    return;
                }
            }

            Console.WriteLine("Not Found.");
        }


        public void SearchByCity(string city)
        {
            for (int i = 0; i < count; i++)
            {
                if (people[i].City == city)
                {
                    people[i].Display();
                }
            }
        }


        public void SortByName()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(people[j].FirstName, people[j + 1].FirstName) > 0)
                    {

                        AddressBook temp = people[j];
                        people[j] = people[j + 1];
                        people[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted List:");
            DisplayAll();
        }
    }
}