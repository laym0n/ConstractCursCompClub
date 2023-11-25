using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xceed.Wpf.Toolkit;

namespace ConstractCurs.ViewModel
{

    public class ReservationViewModel
    {
        private BLL.Interfaces.IReservationService resServ;

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int[] _PlacesId;
        public int[] PlacesId
        {
            get { return _PlacesId; }
            set
            {
                _PlacesId = value;
                NotifyPropertyChanged("PlaceId");
            }
        }
        #endregion
        #region Command

        private RelayCommand _ReservAccept;
         public RelayCommand ReservAccept
        {
            get
            {
                return _ReservAccept ?? (_ReservAccept = new RelayCommand(obj =>
                {

                    var values = (object[])obj;
                    DateTime DateStart = (DateTime)values[0];
                    DateTime TimeStart = (DateTime)values[1];
                    DateTime TimeEnd = (DateTime)values[2];
                    DateTime DateEnd = DateStart.Date.AddHours(TimeEnd.Hour);
                    DateStart = DateStart.Date;
                    DateStart = DateStart.AddHours(TimeStart.Hour);
                    if(DateStart>DateEnd)
                    {
                        var mb = new Windows.CustomMessageBox("Неверный выбор даты", "Очко");
                        mb.ShowDialog();
                    }
                    else
                    {
                        ShowFreeComps(DateStart, DateEnd);
                    }

                }));

            }
        }

        #endregion
        public ReservationViewModel(BLL.Interfaces.IReservationService resServ)
        {

            this.resServ = resServ;
        }

        public void ShowFreeComps(DateTime start, DateTime end)
        {
            if(start!=null && end!=null)
            {
                int jopa = 0;
                var comps = resServ.CheckFreeComputers(start, end);
                foreach(var c in comps)
                {
                    PlacesId[jopa] = c.Id;
                    jopa++;
                }
            }
        }

    }
}
