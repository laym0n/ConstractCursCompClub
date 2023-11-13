using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class RAMModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public RAMModel() { }
        public RAMModel(DAL.EntitiesCodeFirst.RAM ram)
        {
            Id = ram.Id;
            Name = ram.Name;
            Specifications = ram.Specifications;
        }
    }
}
