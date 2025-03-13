using PhoneBook.Domains;

namespace PhoneBook.Services
{
    public class PhoneContactService
    {

        #region Variables
        private List<PhoneContact> _contacts;
        #endregion

        #region Constructor
        public PhoneContactService()
        {
            if (_contacts == null)
            {
                _contacts = new List<PhoneContact>();
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method to add a new contact 
        /// </summary>
        /// <param name="name">Name - String value</param>
        /// <param name="phoneNumber">Phone number - String value</param>
        /// <returns></returns>
        public void Add()
        {
            Console.Clear();
            Console.Write("Enter Contact Name:              ");
            string name = Console.ReadLine();
            Console.Write("Enter Contact Phone Number:      ");
            string phoneNumber = Console.ReadLine();
            try
            {
                var isExist = _contacts.Any(c => c.PhoneNumber == phoneNumber);
                if (isExist || string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrWhiteSpace(phoneNumber))
                {
                    Console.WriteLine("Phone number already exist, Or name is null or empty, Or phone number is null or empty ");
                }
                else
                {
                    _contacts.Add(new PhoneContact { Name = name, PhoneNumber = phoneNumber });
                    Console.WriteLine("Added successfuly. ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown Error.");
            }
        }

        /// <summary>
        /// Method to edit a contact's phone number
        /// </summary>
        /// <param name="name">Name - String value</param>
        /// <param name="phoneNumber">Phone number - String value</param>
        /// <returns></returns>
        public void EditePhoneNumber()
        {
            Console.Clear();
            try
            {
                Console.Write("Enter a contact name to edite phone number:      ");
                var name = Console.ReadLine();
                if (_contacts.Any(c => c.Name == name))
                {
                    Console.Write("Enter new phone number:      ");
                    var phoneNumber = Console.ReadLine();
                    if (_contacts.Any(c => c.PhoneNumber == phoneNumber))
                    {
                        Console.WriteLine("Phone number already exist");
                    }
                    else
                    {
                        Console.WriteLine("Edit done successfuly");
                        _contacts.Add(new PhoneContact { Name = name, PhoneNumber = phoneNumber });
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Name not exist");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
            }
        }

        /// <summary>
        /// Method to delete a contact
        /// </summary>
        /// <param name="name">Name - String value</param>
        /// <returns></returns>
        public void Delete()
        {
            Console.Clear();
            Console.Write("Delet a contact by name:     ");
            var deleteByName = Console.ReadLine();
            var deleteContact = _contacts.Where(c => c.Name == deleteByName).ToList();
            try
            {
                foreach (var contact in deleteContact)
                {
                    Console.WriteLine("Deleted successfuly");
                    _contacts.Remove(contact);
                    Console.WriteLine("");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
            }
        }

        /// <summary>
        /// Method to search for a contact by name
        /// </summary>
        /// <param name="name">Name - String value</param>
        /// <returns></returns>
        public void SearchContactByName()
        {
            Console.Clear();
            Console.Write("Enter a contact name to search:      ");
            var name = Console.ReadLine();
            var SearchByName = _contacts.Where(c => c.Name == name).ToList();
            try
            {
                foreach (var contact in SearchByName)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
                    Console.WriteLine("");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Uknown error try again");
            }
        }

        /// <summary>
        /// Method to search for a contact by phone number
        /// </summary>
        /// <param name="phoneNumber">Phone Number - String value</param>
        /// <returns></returns>
        public void SearchContactByPhoneNumber()
        {
            Console.Clear();
            Console.Write("Enter contact phone number to search:      ");
            var phoneNumber = Console.ReadLine();
            var searchByPhoneNumber = _contacts.Where(c => c.PhoneNumber == phoneNumber).ToList();
            try
            {
                foreach (var contact in searchByPhoneNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
                    Console.WriteLine("");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
            }
        }

        /// <summary>
        /// Method to print all contacts
        /// </summary>
        public void PrintAll()
        {
            Console.Clear();
            try
            {
                foreach (var contact in _contacts)
                {
                    Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
                    Console.WriteLine("************************************");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
            }
            Console.WriteLine("");
        }

        #endregion
    }
}
