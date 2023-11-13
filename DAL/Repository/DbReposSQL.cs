using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfaces;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;

namespace DAL.Repository
{
    public class DbReposSQL:IDbRepos
    {
        private ComputerClubContext db;
        private ComputerCompositionRepositorySQL computerCompositionRepository;
        private ComputerPlacesRepositorySQL computerplacesRepository;
        private HeadphonesRepositorySQL headphonesRepository;
        private KeyboardRepositorySQL keyboardRepository;
        private MonitorRepositorySQL monitorRepository;
        private MouseRepositorySQL mouseRepository;
        private ProcessorRepositorySQL processorRepository;
        private RAMRepositorySQL ramReposisory;
        private ReservationsRepositorySQL reservationsRepository;
        private UserRepositorySQL userRepository;
        private VideoCardRepositorySQL videocardRepository;

        public DbReposSQL()
        {
            db = new ComputerClubContext();
        }
        
        public IRepository<ComputerComposition> ComputerCompositions
        {
            get
            {
                if (computerCompositionRepository == null)
                    computerCompositionRepository = new ComputerCompositionRepositorySQL(db);
                return computerCompositionRepository;
            }
        }
        public IRepository<ComputerPlaces> Places
        {
            get
            {
                if (computerplacesRepository == null)
                    computerplacesRepository = new ComputerPlacesRepositorySQL(db);
                return computerplacesRepository;
            }
        }
        public IRepository<Headphones> Headphones
        {
            get
            {
                if (headphonesRepository == null)
                    headphonesRepository = new HeadphonesRepositorySQL(db);
                return headphonesRepository;
            }
        }
        public IRepository<Keyboard> Keyboards
        {
            get
            {
                if (keyboardRepository == null)
                    keyboardRepository = new KeyboardRepositorySQL(db);
                return keyboardRepository;
            }
        }
        public IRepository<Monitor> Monitors
        {
            get
            {
                if (monitorRepository == null)
                    monitorRepository = new MonitorRepositorySQL(db);
                return monitorRepository;
            }
        }
        public IRepository<Mouse> Mouses
        {
            get
            {
                if (mouseRepository == null)
                    mouseRepository = new MouseRepositorySQL(db);
                return mouseRepository;
            }
        }
        public IRepository<Processor> Processors
        {
            get
            {
                if (processorRepository == null)
                    processorRepository = new ProcessorRepositorySQL(db);
                return processorRepository;
            }
        }

        public IRepository<RAM> RAMs
        {
            get
            {
                if (ramReposisory == null)
                    ramReposisory = new RAMRepositorySQL(db);
                return ramReposisory;
            }
        }
        public IRepository<Reservations> Reservations
        {
            get
            {
                if (reservationsRepository == null)
                    reservationsRepository = new ReservationsRepositorySQL(db);
                return reservationsRepository;
            }
        }
        public IRepository<Users> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepositorySQL(db);
                return userRepository;
            }
        }
        public IRepository<VideoCard> VideoCards
        {
            get
            {
                if (videocardRepository == null)
                    videocardRepository = new VideoCardRepositorySQL(db);
                return videocardRepository;
            }
        }
        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
