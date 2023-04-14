using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMangement
{
    public class AddressProgram
    {
         List<Address> addresslist = new List<Address>();
         public static Dictionary<string, List<Address>> dict = new Dictionary<string, List<Address>>();
        public void AddContact(Address contact)
        {
            addresslist.Add(contact);
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Addres = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
        }
        public void EditContact(string name)
        {
            foreach (var contact in addresslist)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("Choose the field you want to edit :\n 1.First name:\n 2.Last name:\n 3.Address:\n 4.City:\n 5.State:\n 6.Zip code:\n 7.Phone Number:\n 8.Email:\n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter you want to edit");
                            string first = Console.ReadLine();
                            contact.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter you want to edit");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter you want to edit");
                            string address = Console.ReadLine();
                            contact.Addres = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter you want to edit");
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter you want to edit");
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter you want to edit");
                            string zip = Console.ReadLine();
                            contact.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter you want to edit");
                            string phone = Console.ReadLine();
                            contact.PhoneNumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter you want to edit");
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        default:
                            Console.WriteLine("enter Correct Option\n");
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            Address delete = new Address();
            foreach (var contact in addresslist)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    delete = contact;
                }
            }
            addresslist.Remove(delete);
            Console.WriteLine(name + " contact is deleted \n");
        }
        public void Display()
        {
            foreach (var contact in addresslist)
            {
                Console.WriteLine("Contact Details are..\n");
                Console.Write("Firstname: " + contact.FirstName + "\n" + "Lastname: " + contact.LastName + "\n" + "Address: " + contact.Addres + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "Phone No.: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email + "\n");
            }
        }
        public void MultipleAddressBook()
        {
            Console.WriteLine("Enter no. of AddressBooks");
            int noOfAddressBooks = Convert.ToInt32(Console.ReadLine());
            while (noOfAddressBooks > 0)
            {
                Console.WriteLine("Enter Address BookName :");
                string addressBookName = Console.ReadLine();
                dict.Add(addressBookName, addresslist);
                noOfAddressBooks--;
            }
        }
        public void DisplayAddressBook()
        {
            Console.WriteLine("Enter name of dictionary to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in dict)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Details are:\n" + "Firstname: " + data.FirstName + "\n" + "Lastname: " + data.LastName + "\n" + "Address: " + data.Addres + "\n" + "City: " + data.City + "\n" + "State: " + data.State + "\n" + "Zip: " + data.Zip + "\n" + "Phone No.: " + data.PhoneNumber + "\n" + "Email: " + data.Email + "\n");
                    }
                }
            }
        }
        public void Search_person_city_state()
        {
            Console.WriteLine("Search a Person by 1.city 2.state");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter The City Name to search");
                    string city = Console.ReadLine();
                    foreach (Address contact in this.addresslist.FindAll(e => e.City == city))
                    {
                        Console.WriteLine(contact.FirstName + " " + contact.LastName + " is from " + contact.City);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter The state Name to search");
                    string state = Console.ReadLine();
                    foreach (Address contact in this.addresslist.FindAll(e => e.State == state))
                    {
                        Console.WriteLine(contact.FirstName + " " + contact.LastName + " is from " + contact.State);
                    }
                    break;

            }

        }
        public void Count_person_city_state()
        {
            int count = 0;
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("\n1.City \n2.State");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (Address personal_Details in this.addresslist.FindAll(c => c.City == city))
                    {
                        count = this.addresslist.Count();
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Address personal_Details in this.addresslist.FindAll(c => c.State == state))
                    {
                        count = this.addresslist.Count();
                    }
                    Console.WriteLine(count);
                    break;
            }

        }
         
        public void WriteFile()
        {
            Console.WriteLine("FileWriter");
            string path = "D:\\C#\\AddressBookMangement\\AddressBookMangement\\file.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                
                foreach (var Adress in addresslist)
                {
                    sr.WriteLine("\nfirstname: " + Adress.FirstName + "\nlastname: " + Adress.LastName + "\naddress: " + Adress.Addres + "\ncity: " + Adress.City + "\nstate: " + Adress.State + "\nzip: " + Adress.Zip + "\nphoneno: " + Adress.PhoneNumber + "\nemail: " + Adress.Email);
                }
            }

        }
        public void ReadFile()
        {
            Console.WriteLine("The Contact List Using Stream Reader");
            string path = "D:\\C#\\AddressBookMangement\\AddressBookMangement\\file.txt";
            using (StreamReader se = File.OpenText(path))
            {
                string s = " ";
                while ((s = se.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}

