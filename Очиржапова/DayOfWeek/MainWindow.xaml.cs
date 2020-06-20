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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DayOfWeek
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassDay dw = new ClassDay();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Day_TextChanged(object sender, TextChangedEventArgs e)
        {
            dw.SetDay(Convert.ToInt32(day.Text));
        }

        private void Month_TextChanged(object sender, TextChangedEventArgs e)
        {
            dw.SetMonth(Convert.ToInt32(month.Text));
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            dw.SetYear(Convert.ToInt32(year.Text));
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            result.Content = "Вы родились " + dw.GetDayOfTheWeek();
        }
    }
}
