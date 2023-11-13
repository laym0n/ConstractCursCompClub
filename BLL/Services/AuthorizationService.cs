using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.EntitiesCodeFirst;

namespace BLL.Services
{
    public class AuthorizationService:IAuthorizationService
    {
        IDbRepos context;
        UserInfo curUser;

        public AuthorizationService(IDbRepos context)
        {
            this.context = context;
            curUser = new UserInfo { type = UserType.Unauthorized, id = -1, Name = "" };
        }
        public UserInfo GetCurrentUser()
        {
            return curUser;
        }
        public bool TryAuthorization (string UserName, string Password)
        {
            Users user = context.Users.GetList().Where(i => i.Username == UserName).FirstOrDefault();
            if(user!=null)
            {
                if(user.Password==Password)
                {
                    curUser.type = UserType.Client;
                    curUser.id = user.Id;
                    curUser.Name = user.FirstName;
                    return true;
                }
            }
            return false;
        }
        public void LogOut()
        {
            curUser.type = UserType.Unauthorized;
            curUser.id = -1;
        }

        public void CreateCustomer(string Name, string UserName,string PassWord)
        {
            Users user = new Users
            {
                Username = UserName,
                FirstName = Name,
                Password = PassWord,
                Id = context.Users.GetList().OrderByDescending(i => i.Id).FirstOrDefault() == null ? 0 : context.Users.GetList().OrderByDescending(i => i.Id).FirstOrDefault().Id + 1
            };
    }

    }
}
