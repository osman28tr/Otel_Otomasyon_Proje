using System;
using System.Data;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Hotel.ReservationClasses
{
    internal class RoomBasePrice
    {
        public int id { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private Database.Database _db;
        public RoomBasePrice()
        {
            _db = new Database.Database();
        }
        public void SavePrice()
        {
            string UpdateString = @"insert into RoomBasePrice(Price,StartDate,EndDate,Update_date) 
                                    Values (@Price, @StartDate,@EndDate,@Update_date)";
            
            var cmd = new SqlCommand(UpdateString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@Price", this.Price);
            cmd.Parameters.AddWithValue("@StartDate", this.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", this.EndDate);
            cmd.Parameters.AddWithValue("@Update_date", DateTime.Now);
            cmd.ExecuteNonQuery();
            _db.Baglanti().Close();
        }

        public void UpdatePrice()
        {
            var UpdateString = @"update RoomBasePrice 
                               set Price = @Price, StartDate = @StartDate, EndDate = @EndDate , Update_date = @Update_date 
                               where id = " + this.id;
            var cmd = new SqlCommand(UpdateString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@Price", this.Price);
            cmd.Parameters.AddWithValue("@StartDate", this.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", this.EndDate);
            cmd.Parameters.AddWithValue("@Update_date", DateTime.Now);
            cmd.ExecuteNonQuery();
            _db.Baglanti().Close();
        }

        public decimal GetPrice(DateTime date)
        {
            var reservationAddQuery = @"select top 1 Price
                                            from RoomBasePrice
                                            where @dateTime >= StartDate and @dateTime <= EndDate
                                            order by Update_date desc";
            var cmd = new SqlCommand(reservationAddQuery, _db.Baglanti());
            cmd.Parameters.AddWithValue("@dateTime", date);
            var price = Convert.ToDecimal(cmd.ExecuteScalar());
            return price < 1 ? 1000M : price;
        }

        public DataTable GetPrices()
        {
            var query = @"select *
                         from RoomBasePrice ";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();
            return dt;
        }

        public void DeletePrice()
        {
            var deleteQuery = "Delete From RoomBasePrice where id = " + this.id;
            SqlCommand cmd = new SqlCommand(deleteQuery, _db.Baglanti());
            cmd.ExecuteNonQuery();
            _db.Baglanti().Close();
        }
    }
}
