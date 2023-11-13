using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class VideoCardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public VideoCardModel() { }
        public VideoCardModel(DAL.EntitiesCodeFirst.VideoCard videocard)
        {
            Id = videocard.Id;
            Name = videocard.Name;
            Specifications = videocard.Specifications;
        }
    }
}
