using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Inetrafces
{
    public interface IPhoneContact
    {
        void Add();
        void EditePhoneNumber();
        void Delete();
        void SearchContactByName();
        void SearchContactByPhoneNumber();
        void PrintAll();
        bool CheckIfUserExistByPhoneNumber(string phoneNumber);
    }
}
