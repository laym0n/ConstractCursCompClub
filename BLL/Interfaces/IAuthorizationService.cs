using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Interfaces
{
    public enum UserType { Unauthorized = 0,Client, Admin}
    public struct UserInfo
    {
        public UserType type;
        public int id;
        public string Name;
    }
    public interface IAuthorizationService
    {
        UserInfo GetCurrentUser();
        bool TryAuthorization(string login, string password);

        void LogOut();

        void CreateCustomer(string name, string login, string pass);
    }
}
