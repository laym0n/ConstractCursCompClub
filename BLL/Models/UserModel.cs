using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Bonuses { get; set; }
        public UserModel() { }
        public UserModel(DAL.EntitiesCodeFirst.Users user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Password = user.Password;
            UserType = user.UserType;
            Balance = user.Balance;
            Bonuses = user.Bonuses;
        }
    }
}
