namespace AdressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Adderess Book");
            Contacts adress = new Contacts("azaruddin","shaik","17","Atmakur","AP","518422","India","8297214219","ajarpopo@gmail.com");
            adress.Display();
        }
    }
}
