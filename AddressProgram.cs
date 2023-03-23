using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMangement
{
    public class AddressProgram
    {
        List<Address> list = new List<Address>();
        public void details()
        {

            Console.WriteLine("Enter no.of details want to print:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)

            {
                Address address = new Address();
                Console.Write("Enter firstName: ");
                address.firstname = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                address.lastname = Console.ReadLine();
                Console.Write("Enter Address: ");
                address.address = Console.ReadLine();
                Console.Write("Enter city: ");
                address.city = Console.ReadLine();
                Console.Write("Enter state: ");
                address.state = Console.ReadLine();
                Console.Write("Enter phone number: ");
                address.phoneNo = Console.ReadLine();
                Console.Write("Enter postcode: ");
                address.postcode = Console.ReadLine();
                list.Add(address);
                Console.Write("Enter Country: ");
                address.country = Console.ReadLine();
                list.Add(address);
                Console.Write("Enter email: ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                Console.WriteLine(address.firstname + "\n" + address.lastname + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNo + "\n" + address.postcode + "\n" + address.country + "\n" + address.eMail);
            }

        }
    }
}
