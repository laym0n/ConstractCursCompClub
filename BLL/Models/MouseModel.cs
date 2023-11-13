using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MouseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public MouseModel() { }
        public MouseModel(DAL.EntitiesCodeFirst.Mouse mouse)
        {
            Id = mouse.Id;
            Name = mouse.Name;
            Specifications = mouse.Specifications;
        }
    }
}
