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
using System.Windows.Markup;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Windows.Annotations.Storage;

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
            CloneChartMonth.Visibility = Visibility.Visible;
            string clone = XamlWriter.Save(CloneChartMonth);
            Zone.Children.Clear();
            Zone.Children.Add(DataChenge.Clone(clone));
            CloneChartMonth.Visibility = Visibility.Hidden;
        }

        private void Quartal_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
            
        private void Yaer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CloneChartYear.Visibility = Visibility.Visible;
            string clone = XamlWriter.Save(CloneChartYear);
            Zone.Children.Clear();
            Zone.Children.Add(DataChenge.Clone(clone));
            CloneChartYear.Visibility=Visibility.Hidden;
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
