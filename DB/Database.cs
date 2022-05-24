using System.Data.SqlClient;

namespace Otel_Rezervasyon.Database
{
    internal class Database
    {
        public SqlConnection Baglanti() 
        {
            const string conString = @"Data Source=DESKTOP-7LR4Q85\SQLEXPRESS;Initial Catalog=OtelRezervasyon;Integrated Security=True";
            var con = new SqlConnection(conString);
            con.Open();
            return con;
        }
    }
}
