using System;
using System.Data.SqlClient;
using System.Data;
namespace Otel_Rezervasyon.Hotel.ReservationClasses
{
    public class ReservationDetail
    {
        public int ReservationDetailId { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public bool PaymentStatus { get; set; }
        public int RoomId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ReservationCode { get; set; }
        public bool ReservationState { get; set; }

        private readonly Database.Database _db;

        public ReservationDetail()
        {
            PaymentStatus = false;
            _db = new Database.Database();
        }
        public void Save()
        {
            RoomId = GetRoom();
            var saveQuery = "Insert Into ReservationDetail(ReservationId,CustomerId,ReservationStartDate,ReservationEndDate,PaymentStatus,PaymentDate,ReservationCode,RoomId)" +
                            "Values (@ReservationId,@CustomerId,@ReservationStartDate,@ReservationEndDate,@PaymentStatus,@PaymentDate,@ReservationCode,@RoomId);" +
                            "SELECT SCOPE_IDENTITY();";
            var cmd = new SqlCommand(saveQuery, _db.Baglanti());
            cmd.Parameters.AddWithValue("@ReservationId", this.ReservationId);
            cmd.Parameters.AddWithValue("@CustomerId", this.CustomerId);
            cmd.Parameters.AddWithValue("@ReservationStartDate", this.ReservationStartDate);
            cmd.Parameters.AddWithValue("@ReservationEndDate", this.ReservationEndDate);
            cmd.Parameters.AddWithValue("@PaymentStatus", this.PaymentStatus);
            cmd.Parameters.AddWithValue("@PaymentDate", DBNull.Value);
            cmd.Parameters.AddWithValue("@ReservationCode", this.ReservationCode);
            cmd.Parameters.AddWithValue("@RoomId", this.RoomId);

            this.ReservationDetailId = Convert.ToInt32(cmd.ExecuteScalar());
            _db.Baglanti().Close();

        }

        private int GetRoom()
        {
            // rezervasyonun başlangıç ve bitiş tarihleri arasındaki boş odaları listeler
            var saveQuery = @"SELECT Top 1 RoomId 
                              FROM Room 
                              WHERE RoomId 
                              not in( SELECT r.RoomId
                              FROM dbo.ReservationDetail rd inner join Room r on rd.RoomId = r.RoomId
                              WHERE (ReservationStartDate<=@ReservationEndDate and ReservationEndDate >= @ReservationStartDate) and rd.ReservationState = 1)";
            var cmd = new SqlCommand(saveQuery, _db.Baglanti());
            cmd.Parameters.AddWithValue("@ReservationStartDate", this.ReservationStartDate);
            cmd.Parameters.AddWithValue("@ReservationEndDate", this.ReservationEndDate);
            _db.Baglanti().Close();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void PaymentUpdate()
        {
            // ödeme tarihini ve durumunu günceller
            var UpdateString = "update ReservationDetail " +
                               "set PaymentDate = @PaymentDate,PaymentStatus = @PaymentStatus " +
                               "where ReservationDetailId=" + this.ReservationDetailId;
            var cmd = new SqlCommand(UpdateString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@PaymentDate", this.PaymentDate);
            cmd.Parameters.AddWithValue("@PaymentStatus", this.PaymentStatus);
            cmd.ExecuteNonQuery();
            _db.Baglanti().Close();

        }

        public DataTable GetReservationDetailForCustomer(int CustomerId)
        {
            
            var query =
                "SELECT ReservationCode,Reservation.ReservationType,Reservation.ReservationPrice,Reservation.ReservationLastPaymentDate,ReservationStartDate,ReservationEndDate,PaymentStatus,PaymentDate,RoomId,ReservationState " +
                "FROM ReservationDetail inner join Reservation " +
                "on ReservationDetail.ReservationId=Reservation.ReservationId " +
                "WHERE CustomerId = " + CustomerId;
            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();
            return dt;

        }

        public DataTable CheckReservationCode(string ReservationCode)
        {
            // rezervasyon koduna göre rezervasyonu getirir
            this.ReservationCode = ReservationCode;
            var query = $@"SELECT CustomerId,ReservationDetail.ReservationId,ReservationDetailId,Reservation.ReservationType,Reservation.ReservationPrice,Reservation.ReservationLastPaymentDate,ReservationStartDate,ReservationEndDate,PaymentStatus,PaymentDate,RoomId,ReservationState 
                            FROM ReservationDetail inner join Reservation on ReservationDetail.ReservationId=Reservation.ReservationId
                            WHERE ReservationDetail.ReservationCode = '{ReservationCode}'";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();

            return dt;
        }

        public void ReservationCancel()
        {
            var UpdateString = "update ReservationDetail " +
                               "set ReservationState = 0 " +
                               "where ReservationDetailId=" + this.ReservationDetailId;
            var cmd = new SqlCommand(UpdateString, _db.Baglanti());
            cmd.ExecuteNonQuery();
            _db.Baglanti().Close();
        }

        public string GetReservationType()
        {
            var query =
                "SELECT Reservation.ReservationType " +
                "FROM ReservationDetail inner join Reservation " +
                "on ReservationDetail.ReservationId=Reservation.ReservationId " +
                "WHERE ReservationDetailId=" + this.ReservationDetailId;

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();
            return dt.Rows[0].ItemArray[0].ToString();
        }

        public bool DateUpdate()
        {
            var UpdateString = "update ReservationDetail " +
                               "set ReservationStartDate = @ReservationStartDate , ReservationEndDate = @ReservationEndDate " +
                               "where ReservationDetailId = " + this.ReservationDetailId;

            var cmd = new SqlCommand(UpdateString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@ReservationStartDate", this.ReservationStartDate);
            cmd.Parameters.AddWithValue("@ReservationEndDate", this.ReservationEndDate);

            return cmd.ExecuteNonQuery()==1;
        }

        public void PriceUpdate(decimal addprice)
        {
            var UpdateString = "update Reservation " +
                              $"set ReservationPrice = @price + @addprice " + // en düşük fiyat * kaldığı gün sayısı + ceza tutarı
                               "where ReservationId = " + this.ReservationId;


            var cmd = new SqlCommand(UpdateString, _db.Baglanti());

            var Getprice = new RoomBasePrice();
            var price = 0M;
            for (var dateTime = this.ReservationStartDate; dateTime <= this.ReservationEndDate; dateTime = dateTime.AddDays(1))
            {
                price += Getprice.GetPrice(dateTime);
            }

            cmd.Parameters.AddWithValue("@addprice",addprice);
            cmd.Parameters.AddWithValue("@price", price);

            cmd.ExecuteNonQuery();
        }
    }
}
