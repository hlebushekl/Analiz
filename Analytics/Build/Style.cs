using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows;

namespace Analytics.Build
{
    public class DataChenge
    {
        public static string nameTable = "Акции";
        public static UIElement Clone(string a)
        { 
            byte[] byteArray = Encoding.UTF8.GetBytes(a);
            MemoryStream ms = new MemoryStream(byteArray);
            StreamReader str = new StreamReader(ms);
            XmlReader xamel = XmlReader.Create(str);
            StackPanel reder = (StackPanel)XamlReader.Load(xamel);

            return reder;
        }
    }
}