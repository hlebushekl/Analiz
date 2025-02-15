using System.Data;
using System.Data.OleDb;

namespace Analytics.Property
{
    public class DataBase
    {
        public static OleDbConnection connection
        {
            get { return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=3Norml.accdb"); }
        }
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
        public static string TabelInsertion(int i, int j)
        {
            string result;
            DataTable table = Data();
            result = table.Rows[i][j].ToString();
            return result;
        }
        public static int Lenght()
        {
            int result;
            DataTable table = Data();
            result = table.Rows.Count;
            return result;
        }
    }
}
