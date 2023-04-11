using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMangement
{
    public class Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void Print()
        {
            Console.WriteLine(this.FirstName + this.LastName);
        }
    }
   

}
