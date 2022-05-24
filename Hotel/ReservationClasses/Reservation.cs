using System;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Hotel.ReservationClasses
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime ReservationLastPaymentDate { get; set; }
        public decimal ReservationPrice { get; set; }
        public string ReservationType { get; set; }

       
        private readonly Database.Database _db;
        private readonly RoomBasePrice _basePrice;

        public Reservation()
        {
            _db = new Database.Database();
            _basePrice = new RoomBasePrice();
        }

        public decimal GetPrice(DateTime startdate, DateTime enddate)
        {
            decimal tolalPrice = 0;
            for (var dateTime = startdate; dateTime <= enddate ; dateTime = dateTime.AddDays(1))   
            {
                tolalPrice += _basePrice.GetPrice(dateTime);
            }
            
            switch (ReservationType)
            {
                case "Prepaid_Reservation":
                    ReservationPrice = tolalPrice * 0.75M;
                    break;
                case "60Day_Reservation":
                    ReservationPrice = tolalPrice * 0.85M;
                    break;
                case "Incentive_Reservation":
                    var aralik = enddate - startdate;
                    // doluluk oranı %60 veya daha az ise fiyat %20 düşürülür.
                    ReservationPrice = 27 >= SolidityRatio(startdate, enddate) && aralik.TotalDays <= 30
                        ? tolalPrice * 0.8M
                        : tolalPrice;
                    break;
                default:
                    ReservationPrice = tolalPrice;
                    break;
            }

            return ReservationPrice;
        }

        public void AddReservation()
        {
            string reservationAddQuery = "Insert Into Reservation(ReservationLastPaymentDate,ReservationPrice,ReservationType) " +
                                         "Values(@ReservationLastPaymentDate,@ReservationPrice,@ReservationType);" +
                                         "SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(reservationAddQuery,_db.Baglanti());
            cmd.Parameters.AddWithValue("@ReservationLastPaymentDate", ReservationLastPaymentDate);
            cmd.Parameters.AddWithValue("@ReservationPrice", ReservationPrice);
            cmd.Parameters.AddWithValue("@ReservationType", ReservationType);

            ReservationId = Convert.ToInt32(cmd.ExecuteScalar());
            _db.Baglanti().Close();
        }
            
        public int SolidityRatio(DateTime startdate, DateTime enddate)
        {
            //Doluluk oranı
            var reservationAddQuery = "Select COUNT(*) From ReservationDetail " +
                                      "Where ReservationEndDate > @startdate " +
                                      "AND ReservationStartDate < @enddate";
            SqlCommand cmd = new SqlCommand(reservationAddQuery, _db.Baglanti());
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@enddate", enddate);
                
            var TotalResRoomCount = Convert.ToInt32(cmd.ExecuteScalar());
            _db.Baglanti().Close();
            return TotalResRoomCount;
        }
    }
}
