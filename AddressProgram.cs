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
            //List<Address> list = new List<Address>();
            Console.WriteLine("Enter no.of details want to print:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)

            {
                if (i == 0)
                {
                    Console.WriteLine("Information 1");
                }
                else if (i == 1)
                {
                    Console.WriteLine("Information 2");
                }
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
            Console.WriteLine("Edit by using First Name: ");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                Address address = new Address();
                if (data.firstname == name)
                {

                    Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter first name ");
                            data.firstname = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter last name ");
                            data.lastname = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter address");
                            data.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter city");
                            data.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter state");
                            data.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter phne number");
                            data.phoneNo = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter email");
                            data.eMail = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine(data.firstname + "\n" + data.lastname + "\n" + data.address + "\n" + data.city + "\n" + data.state + "\n" + data.phoneNo + "\n" + data.postcode + "\n" + data.country + "\n" + data.eMail);

                }


            }



        }
        public void deleteContact()
        {
            Address address = new Address();
            Console.WriteLine("Enter name to delete details");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstname.Equals(name))
                    address = data;

            }
            list.Remove(address);
            Console.WriteLine("contact was deleted" + address.firstname + "\n" + address.lastname + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNo + "\n" + address.postcode + "\n" + address.country + "\n" + address.eMail);


        }
    }
}
