using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class Contacts
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        string country;
        string phone;
        string email;

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string country, string phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.country = country;
            this.phone = phone;
            this.email = email;
            

        }
         public void Display()
        {
            Console.WriteLine("Name of the Person {0}{1}, Adress is :{2}, his from {3} city and {4} sate.pincode is {5} His from {6}", firstName, lastName, address, city, state, zip, country);
            Console.WriteLine("His Number is {0} and emails is {1}", phone, email);
        }
       
       
    } 
}
