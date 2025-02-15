using System.Data;
using System.Data.OleDb;

namespace Analytics.Property
{
    public class DataBase
    {
        public static OleDbConnection connection
        {
            get { return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Test.accdb"); }
        }
    }

    public class DataSerch
    {
        public static DataTable Data()
        {
            string NameTable = Build.DataChenge.nameTable;
            OleDbConnection connection = DataBase.connection;
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM {NameTable}", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            connection.Close();

            return data.Tables[0];
        }
        public static DataTable Year(int i)
        {
            int YEAR = i;
            OleDbConnection connection = DataBase.connection;
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM Продажи where YEAR(Дата) = {YEAR}", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            connection.Close();
            return data.Tables[0];
        }
        public static DataTable Months(int i)
        {
            int Month = i;
            OleDbConnection connection = DataBase.connection;
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM Продажи where Month(Дата) = {Month} AND YEAR(Дата) = {2025}", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            connection.Close();
            return data.Tables[0];
        }

        public static DataTable Day(int i)
        {
            int Day = i;
            OleDbConnection connection = DataBase.connection;
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM Продажи where Day(Дата) = {Day}", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            connection.Close();
            return data.Tables[0];
        }
        public static string TabelInsertion(int i, int j)
        {
            string result;
            DataTable table = Data();
            result = table.Rows[i][j].ToString();
            return result;
        }
        public static int Lenght(int i)
        {
            int result;
            DataTable table = Months(i);
            result = table.Rows.Count;
            return result;
        }
        public static int LenghtYear(int i)
        {
            int result;
            DataTable table = Year(i);
            result = table.Rows.Count;
            return result;
        }
    }
}
