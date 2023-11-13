using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
   public class MonitorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }

        public MonitorModel() { }
        public MonitorModel(DAL.EntitiesCodeFirst.Monitor monitor)
        {
            Id = monitor.id;
            Name = monitor.Name;
            Specifications = monitor.Specifications;

        }
    }
}
