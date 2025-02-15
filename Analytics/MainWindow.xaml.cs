using Analytics.Build;
using Analytics.Property;
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

namespace Analytics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Product_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Shop_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Mounth_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Quartal_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Yaer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Custom_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DataYear.Years = 2025;
        }

        private void SaveProduct_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void SaveShop_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
