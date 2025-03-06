using PhoneBook.Domains;

namespace PhoneBook.Services
{
    public class PhoneContactService
    {

        private List<PhoneContact> _contacts;
        /// <summary>
        /// Constructor to initialize the list of contacts
        /// </summary>
        #region Constructor
        public PhoneContactService()
        {
            if (_contacts == null)
            {
                _contacts = new List<PhoneContact>();
            }
        }
        #endregion

        /// <summary>
        /// Method to add a new contact 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        #region Method to add a new contact
        public string AddContact(string name, string phoneNumber)
        {
            try
            {
                _contacts.Add(new PhoneContact { Name = name, PhoneNumber = phoneNumber });
                return "Contact added successfully";
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
                return "";
            }

        }
        #endregion

        /// <summary>
        /// Method to print all contacts
        /// </summary>
        #region Method to print all contacts
        public void PrintAllContacts()
        {
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
        }
        #endregion

        /// <summary>
        /// Method to search for a contact by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region Method to search for a contact by name
        public string SearchContactByUserName(string name)
        {
            try
            {
                foreach (var contact in _contacts)
                {
                    if (contact.Name == name)
                    {
                        Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
                        return $"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}";
                    }
                }
                return "";
            }
            catch (Exception)
            {
                Console.WriteLine("Uknown error try again");
                return "";
            }
        }
        #endregion

        /// <summary>
        /// Method to search for a contact by phone number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        #region Method to search for a contact by phone number
        public string SearchContactByUserPhoneNumber(string phoneNumber)
        {
            try
            {
                foreach (var contact in _contacts)
                {
                    if (contact.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
                        return $"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}";
                    }
                }
                return "";
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
                return "";
            }
        }
        #endregion

        /// <summary>
        /// Method to delete a contact
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region Method to delete a contact
        public string DeleteContact(string name)
        {
            try
            {
                foreach (var contact in _contacts)
                {
                    if (contact.Name == name)
                    {
                        _contacts.Remove(contact);
                        return "Contact deleted successfully";
                    }
                }
                return "";
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
                return "";
            }
        }
        #endregion

        /// <summary>
        /// Method to edit a contact's phone number
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        #region Method to edit a contact's phone number
        public string editePhoneNumber(string name, string phoneNumber)
        {
            try
            {
                foreach (var contact in _contacts)
                {
                    if (contact.Name == name)
                    {
                        contact.PhoneNumber = phoneNumber;
                        return "Phone number updated successfully";
                    }
                }
                return "";
            }
            catch (Exception)
            {
                Console.WriteLine("Unkown error try again");
                return "";
            }
        }
        #endregion

    }
}
