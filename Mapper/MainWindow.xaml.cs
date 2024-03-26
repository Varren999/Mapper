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
using Log;

namespace Mapper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bMaping_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbResult.Text = Convert.ToString(Map(Convert.ToDouble(tbValueToMap.Text), Convert.ToDouble(tbStart1.Text), Convert.ToDouble(tbStop1.Text), Convert.ToDouble(tbStart2.Text), Convert.ToDouble(tbStop2.Text)));
            }
            catch(Exception ex)
            {
                Logger.Error("bMaping_Click: " + ex);
            }
        }

        private double Map(double valueToMap, double start1, double stop1, double start2, double stop2)
        {
            return ((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }
}
