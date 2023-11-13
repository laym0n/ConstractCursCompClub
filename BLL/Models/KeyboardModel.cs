using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class KeyboardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public KeyboardModel() { }
        public KeyboardModel(DAL.EntitiesCodeFirst.Keyboard keyboard)
        {
            Id = keyboard.Id;
            Name = keyboard.Name;
            Specifications = keyboard.Specifications;
        }
    }
}
