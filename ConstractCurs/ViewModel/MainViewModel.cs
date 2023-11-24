using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BLL.Interfaces;
using System.Windows.Controls;
using Ninject;
using ConstractCurs.Unit;
using BLL;
using System.Windows;

namespace ConstractCurs.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private IDbCrud crudServ;
        private IAuthorizationService authServ;
        private IReportService reportServ;
        private IReservationService resServ;

        private Frame MainFrame;
        private MainWindow MainWindow;

        private RelayCommand navigate;
        public RelayCommand NavigateCommand
        {
            get
            {
                return navigate ?? (navigate = new RelayCommand(obj =>
                {
                    var real = (string)obj;
                    switch (real)
                    {
                        case "Auth":
                            NavigatetoToAuthPage();
                            break;
                    }
                }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private Visibility _clientVIs;
        public Visibility ClientVis
        {
            get { return _clientVIs = authServ.GetCurrentUser().type == UserType.Client ? Visibility.Visible : Visibility.Collapsed; }
            set
            {
                _clientVIs = value;
                NotifyPropertyChanged("ClientVis");
            }
        }

        private Visibility _adminVis;
        public Visibility AdminVis
        {
            get { return _adminVis = authServ.GetCurrentUser().type == UserType.Admin ? Visibility.Visible : Visibility.Collapsed; }
            set
            {
                _adminVis = value;
                NotifyPropertyChanged("AdminVis");
            }
        }

        /*private Visibility _notSel;
        public Visibility NotSel
        {
            get { return _notSel = authServ.GetCurrentUser().type != UserType.Seller ? Visibility.Visible : Visibility.Collapsed; }
            set
            {
                _notSel = value;
                NotifyPropertyChanged("NotSel");
            }
        }*/

        public void UpdateAuth()
        {
            NotifyPropertyChanged("ClientVis");
            NotifyPropertyChanged("CustomerVis");
            /*NotifyPropertyChanged("NotSel");*/
        }



        public MainViewModel( Frame mainFraim, MainWindow mainWindow)
        {
            MainFrame = mainFraim;

            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("CompClubContext"));

            crudServ = kernel.Get<IDbCrud>();
            resServ = kernel.Get<IReservationService>();
            reportServ = kernel.Get<IReportService>();
            authServ = kernel.Get<IAuthorizationService>();

            MainWindow = mainWindow;
        }
        private void NavigatetoToAuthPage()
        {
            MainFrame.Navigate(new View.AuthPage(authServ, this));
        }
    }
}
