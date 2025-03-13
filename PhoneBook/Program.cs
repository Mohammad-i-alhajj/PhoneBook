namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Phone Book";
            var phoneContactService = new Services.PhoneContactService();
            while (true)
            {
                Console.WriteLine("To enter a new contact, Enter      ==> 1");
                Console.WriteLine("To search by name, Enter           ==> 2");
                Console.WriteLine("To search by phone number, Enter   ==> 3");
                Console.WriteLine("To delete a contact, Enter         ==> 4");
                Console.WriteLine("To edit a contact, Enter           ==> 5");
                Console.WriteLine("To print all contacts, Enter       ==> 6");
                Console.WriteLine("To quit, Enter                     ==> -1");
                Console.WriteLine("");
                Console.Write("Enter the Op Number:     ");

                var opNumber = Console.ReadLine();
                switch (opNumber)
                {
                    case "1":
                        do
                        {
                            phoneContactService.Add();
                            Console.WriteLine("Press -1 to exit or any key to continue");
                        } while (Console.ReadLine() != "-1");
                        break;
                    case "2":
                        phoneContactService.SearchContactByName();
                        break;
                    case "3":
                        phoneContactService.SearchContactByPhoneNumber();
                        break;
                    case "4":
                        phoneContactService.Delete();
                        break;
                    case "5":
                        phoneContactService.EditePhoneNumber();
                        break;
                    case "6":
                        phoneContactService.PrintAll();
                        break;
                    case "-1":
                        Console.Clear();
                        Console.WriteLine("Exited:   ");
                        Console.WriteLine("");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Unkown Op:       ");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}