using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Analytics.Property
{
    public class DataYear
    {
        public static int Years = 2025;
        public static int YearSerchProductA() 
        {
            int result = 0;
            DataTable dataTable = DataSerch.Year(Years);
            for (int i = 0; DataSerch.LenghtYear(2025) > i; i++) 
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int YearSerchProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Year(Years);
            for (int i = 0; DataSerch.LenghtYear(2025) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
    }
    public class DataMonths
    {
        public static int JanuaryProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(1);
            for (int i = 0; DataSerch.Lenght(1) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int JanuaryProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(1);
            for (int i = 0; DataSerch.Lenght(1) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int FebruaryProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(2);
            for (int i = 0; DataSerch.Lenght(2) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int FebruaryProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(2);
            for (int i = 0; DataSerch.Lenght(2) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int MarchProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(3);
            for (int i = 0; DataSerch.Lenght(3) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int MarchProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(3);
            for (int i = 0; DataSerch.Lenght(3) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int AprilProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(4);
            for (int i = 0; DataSerch.Lenght(4) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int AprilProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(4);
            for (int i = 0; DataSerch.Lenght(4) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int MayProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(5);
            for (int i = 0; DataSerch.Lenght(5) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int MayProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(5);
            for (int i = 0; DataSerch.Lenght(5) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int JuneProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(6);
            for (int i = 0; DataSerch.Lenght(6) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int JuneProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(6);
            for (int i = 0; DataSerch.Lenght(6) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int JulyProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(7);
            for (int i = 0; DataSerch.Lenght(7) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int JulyProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(8);
            for (int i = 0; DataSerch.Lenght(7) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int AugustProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(8);
            for (int i = 0; DataSerch.Lenght(8) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int AugustProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(9);
            for (int i = 0; DataSerch.Lenght(8) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int SeptemberProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(9);
            for (int i = 0; DataSerch.Lenght(9) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int SeptemberProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(9);
            for (int i = 0; DataSerch.Lenght(9) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int OctoberProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(10);
            for (int i = 0; DataSerch.Lenght(10) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int OctoberProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(10);
            for (int i = 0; DataSerch.Lenght(10) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int NovemberProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(11);
            for (int i = 0; DataSerch.Lenght(11) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int NovemberProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(11);
            for (int i = 0; DataSerch.Lenght(11) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
        public static int DecemberProductA()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(12);
            for (int i = 0; DataSerch.Lenght(12) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][4]);
            return result;
        }
        public static int DecemberProductB()
        {
            int result = 0;
            DataTable dataTable = DataSerch.Months(12);
            for (int i = 0; DataSerch.Lenght(12) > i; i++)
                result += Convert.ToInt32(dataTable.Rows[i][5]);
            return result;
        }
    }
}
