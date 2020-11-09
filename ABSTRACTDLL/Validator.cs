using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTDLL
{
    public abstract class Validator
    {   
        public abstract bool IsPasswordValid(string password);
        public abstract string HashPassword(string password);
        public abstract bool IsUserExists(string login, string password);
        public abstract bool IsEmailValid(string email);
        public abstract bool IsPhoneValid(string phone);
        public abstract bool IsWebPageAvailable(string url);
        public abstract bool IsDatabaseAccessible(string connectionString);
        public abstract bool IsDateValid(string date);
        public abstract bool IsUserRoot();
        public abstract void Log();
    }
}
