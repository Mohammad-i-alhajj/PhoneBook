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
                            Console.Clear();
                            Console.Write("Enter Contact Name:              ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Contact Phone Number:      ");
                            string phoneNumber = Console.ReadLine();
                            phoneContactService.AddContact(name, phoneNumber);
                            Console.WriteLine("Press -1 to exit or any key to continue");
                        } while (Console.ReadLine() != "-1");
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Enter a contact name to search. if you have more than one contact that's have the same name, I will found the first one:      ");
                        var searchByName = Console.ReadLine();
                        phoneContactService.SearchContactByUserName(searchByName);
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Enter contact phone number to search:      ");
                        var searchByPhoneNumber = Console.ReadLine();
                        phoneContactService.SearchContactByUserPhoneNumber(searchByPhoneNumber);
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Delet a contact by name:     ");
                        var deleteByName = Console.ReadLine();
                        phoneContactService.DeleteContact(deleteByName);
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.Clear();
                        Console.Write("Enter a contact name to edite phone number:      ");
                        var editName = Console.ReadLine();
                        Console.Write("Enter new phone number:      ");
                        var newPhoneNumber = Console.ReadLine();
                        phoneContactService.editePhoneNumber(editName, newPhoneNumber);
                        Console.WriteLine("");
                        break;
                    case "6":
                        Console.Clear();
                        phoneContactService.PrintAllContacts();
                        Console.WriteLine("");
                        break;
                    case "-1":
                        Console.Clear();
                        Console.WriteLine("Exited:   ");
                        Console.WriteLine("");
                        return;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Unkown Op:       ");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
