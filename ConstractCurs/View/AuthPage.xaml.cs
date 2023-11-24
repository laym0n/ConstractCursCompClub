using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ConstractCurs.ViewModel;
using BLL.Interfaces;
using System.Globalization;

namespace ConstractCurs.View
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        private AuthViewModel VM;
        public AuthPage(IAuthorizationService db, MainViewModel mv)
        {
            InitializeComponent();
            VM = new AuthViewModel(db, mv);
            DataContext = VM;
        }

    }
    public class Converter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class NegateVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (Visibility)value;

            if (realV == Visibility.Hidden)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (Visibility)value;

            if (realV == Visibility.Hidden)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }
    }

    public class BoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (bool)value;

            if (realV)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (Visibility)value;

            if (realV == Visibility.Collapsed)
                return false;
            else
                return true;
        }
    }

    public class NegateBoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (bool)value;

            if (!realV)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (Visibility)value;

            if (realV == Visibility.Visible)
                return false;
            else
                return true;
        }
    }

    public class IntToBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var realV = (int)value;

            if (realV < 1)
                return false;
            else
                return true;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}


