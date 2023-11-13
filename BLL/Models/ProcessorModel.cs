using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ProcessorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }

        public ProcessorModel() { }
        public ProcessorModel(DAL.EntitiesCodeFirst.Processor processor)
        {
            Id = processor.Id;
            Name = processor.Name;
            Specifications = processor.Specifications;
        }

    }
}
