using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
namespace DAL.Interfaces
{
    public interface IDbRepos
    {
        IRepository<ComputerComposition> ComputerCompositions {get;}
        IRepository<Users> Users { get; }
        IRepository<Headphones> Headphones { get; }
        IRepository<Keyboard> Keyboards { get; }
        IRepository<Monitor> Monitors { get; }
        IRepository<Reservations> Reservations { get; }
        IRepository<Mouse> Mouses { get; }
        IRepository<VideoCard> VideoCards { get; }
        IRepository<ComputerPlaces> Places { get; }


        int Save();
    }
}
