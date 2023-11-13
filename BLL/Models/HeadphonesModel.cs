using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class HeadphonesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public HeadphonesModel() { }
        public HeadphonesModel(DAL.EntitiesCodeFirst.Headphones headphones)
        {
            Id = headphones.Id;
            Name = headphones.Name;
            Specifications = headphones.Specifications;

        }
    }
}
