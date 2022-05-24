using System.Data;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Admin.AdminClasses
{
    internal class AdminReport
    {
        private readonly Database.Database _db;
        public AdminReport()
        {
            _db = new Database.Database();
        }

        public DataTable ExpectedOccupancyReport()
        {
            //beklenen doluluk oranı
            var query = @"Select * From ExpectedOccupancyReport";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable ExpectedRoomIncomeReport()
        {
            // beklenen oda gelir raporu
            var query = @"Select * From ExpectedRoomIncomeReport";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        
        public DataTable IncentiveReport()
        {
            // Teşvik raporu
            var query = @"Select * From IncentiveReport";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}
