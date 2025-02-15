using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.IO;
using System.Xml;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows;
using System.ComponentModel;
using Analytics.Build;
using System.Collections.ObjectModel;
using Analytics.Property;

namespace Analytics.Build
{
    public class DataChenge
    {
        static readonly string Type = "Наименование";
        static readonly string Name = "Директор";
        static readonly string Phone = "+7 909 442 27 27";
        static readonly string Percent = "Рейтинг: 10";
        public static string nameTable = "Акции";
        public static UIElement Clone(string a, int i)
        {
            string replace = a.Replace(Type, DataSerch.TabelInsertion(i, 1));
            replace = replace.Replace(Name, "Последняя: " + DataSerch.TabelInsertion(i, 2));
            replace = replace.Replace(Phone, "Максимальная: " + DataSerch.TabelInsertion(i, 3));
            replace = replace.Replace(Percent, "Минимальная: " + DataSerch.TabelInsertion(i, 4));

            byte[] byteArray = Encoding.UTF8.GetBytes(replace);
            MemoryStream ms = new MemoryStream(byteArray);
            StreamReader str = new StreamReader(ms);
            XmlReader xamel = XmlReader.Create(str);
            StackPanel reder = (StackPanel)XamlReader.Load(xamel);

            return reder;
        }
    }
}