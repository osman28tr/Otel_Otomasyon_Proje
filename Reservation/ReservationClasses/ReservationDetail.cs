using System;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Reservation.ReservationClasses
{
    internal class ReservationDetail
    {
        public int ReservationDetailId { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public int RoomNumber { get; set; }

        private Database.Database _db;

        public ReservationDetail()
        {
            _db = new Database.Database();
        }


        public void UpdatePayment()
        {
            string UpdateString = "update ReservationDetail set PaymentDate = @PaymentDate," +
                                  "PaymentStatus = @PaymentStatus " +
                                  "where ReservationDetailId=" + this.ReservationDetailId;
            SqlCommand cmd = new SqlCommand(UpdateString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@PaymentDate", this.PaymentDate);
            cmd.Parameters.AddWithValue("@PaymentStatus", this.PaymentStatus);
            cmd.ExecuteNonQuery();
            _db.Baglanti().Close();
        }
    }
}
