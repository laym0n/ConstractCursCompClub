using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using BLL;


namespace ConstractCurs.Unit
{
    public class NinjectRegistrations:NinjectModule
    {
        public override void Load()
        {
            Bind<IDbCrud>().To<DBDataOperations>();
            Bind<IAuthorizationService>().To<AuthorizationService>();
            Bind<IReservationService>().To<ReservationService>();
        }


    }
}
