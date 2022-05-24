using System;

namespace Otel_Rezervasyon.Reservation.ReservationClasses
{
    internal class Reservation
    {

        public int ReservationId { get; set; }
        public DateTime ReservationLastPaymentDate { get; set; }
        public decimal ReservationPrice { get; set; }
        public bool ReservatioDiscountState { get; set; }
        public decimal ReservatioDiscount { get; set; }


        public string GetReservationType(int ReservationId)
        {
            // 60DayAgo_Reservation
            return "Prepaid_Reservation"; //örnek
        }
    }
}
