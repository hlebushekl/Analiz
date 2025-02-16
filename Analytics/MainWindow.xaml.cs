using Analytics.Build;
using Analytics.Property;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Markup;

namespace Analytics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CB_Shop.Text = Analytic.AnalyticYear().ToString();
            if (Analytic.AnalyticYear() > 0)
            {
                CB_product.Text = "Положительный рост";
                CB_product.Foreground = Brushes.Green;
            }
            else if (Analytic.AnalyticYear() < 0)
            {
                CB_product.Text = "Отрицательный рост";
                CB_product.Foreground = Brushes.Red;
            }
        }

        private void Analytic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Zone.Children.Count == 0)
            {
                CloneTender.Visibility = Visibility.Visible;
                string clone = XamlWriter.Save(CloneTender);
                Zone.Children.Add(DataChenge.Clone(clone));
                CloneTender.Visibility = Visibility.Hidden;
            }
            else if (Zone.Children.Contains(CloneChartYear) == true)
            {
                CloneChartYear.Visibility = Visibility.Hidden;
                StackPanel stack = CloneChartYear;
                Zone.Children.Clear();
                Main.Children.Add(stack);
                CloneTender.Visibility = Visibility.Visible;
                string clone = XamlWriter.Save(CloneTender);
                Zone.Children.Add(DataChenge.Clone(clone));
                CloneTender.Visibility = Visibility.Hidden;
            }
            else if (Zone.Children.Contains(CloneChartMonth) == true)
            {
                CloneChartMonth.Visibility = Visibility.Hidden;
                StackPanel stack = CloneChartMonth;
                Zone.Children.Clear();
                Main.Children.Add(stack);
                CloneTender.Visibility = Visibility.Visible;
                string clone = XamlWriter.Save(CloneTender);
                Zone.Children.Add(DataChenge.Clone(clone));
                CloneTender.Visibility = Visibility.Hidden;
            }
            else if (Zone.Children.Count == 1 && Zone.Children.Contains(CloneChartMonth) == false && Zone.Children.Contains(CloneChartYear) == false)
                MessageBox.Show("Аналитика уже открыта");
            else
                MessageBox.Show("Возникла непредвиденная ошибка");
        }
        private void Mounth_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Zone.Children.Count == 0 || (Zone.Children.Count == 1 && Zone.Children.Contains(CloneChartMonth) == false && Zone.Children.Contains(CloneChartYear) == false))
            {
                Zone.Children.Clear();
                CloneChartMonth.Visibility = Visibility.Visible;
                StackPanel stack = CloneChartMonth;
                Main.Children.Remove(CloneChartMonth);
                Zone.Children.Add(stack);
            }
            else if (Zone.Children.Contains(CloneChartMonth) == true)
            {
                MessageBox.Show("Отчёт за месяц уже открыт");
            }
            else if (Zone.Children.Contains(CloneChartYear) == true)
            {
                CloneChartYear.Visibility = Visibility.Hidden;
                StackPanel stack = CloneChartYear;
                Zone.Children.Clear();
                Main.Children.Add(stack);
                StackPanel stackPanel = CloneChartMonth;
                Main.Children.Remove(stackPanel);
                Zone.Children.Add(stackPanel);
                CloneChartMonth.Visibility=Visibility.Visible;
            }
            else
                MessageBox.Show("Возникла непредвиденная ошибка");
        }
            
        private void Yaer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Zone.Children.Count == 0 || (Zone.Children.Count == 1 && Zone.Children.Contains(CloneChartMonth) == false && Zone.Children.Contains(CloneChartYear) == false))
            {
                Zone.Children.Clear();
                CloneChartYear.Visibility = Visibility.Visible;
                StackPanel stack = CloneChartYear;
                Main.Children.Remove(CloneChartYear);
                Zone.Children.Add(stack);
            }
            else if (Zone.Children.Contains(CloneChartYear) == true)
            {
                MessageBox.Show("Отчёт за год уже открыт");
            }
            else if (Zone.Children.Contains(CloneChartMonth) == true)
            {
                CloneChartMonth.Visibility = Visibility.Hidden;
                StackPanel stack = CloneChartMonth;
                Zone.Children.Clear();
                Main.Children.Add(stack);
                StackPanel stackPanel = CloneChartYear;
                Main.Children.Remove(stackPanel);
                Zone.Children.Add(stackPanel);
                CloneChartYear.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Возникла непредвиденная ошибка");
        }
        private void Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
