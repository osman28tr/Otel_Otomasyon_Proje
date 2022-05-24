using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Hotel.ReservationForms
{
    public partial class ReservationChangeDateForm : KryptonForm
    {
        private DateTime oldReservationStartDate;
        private DateTime oldReservationEndDate;
        private ReservationDetail detail;
        private string reservationType;

        public ReservationChangeDateForm(ReservationDetail detail)
        {
            InitializeComponent();
            this.detail = detail;
            oldReservationStartDate = detail.ReservationStartDate;
            oldReservationEndDate = detail.ReservationEndDate;
        }


        private void ReservationChangeDateForm_Load(object sender, EventArgs e)
        {
            reservationType = detail.GetReservationType();
            switch (reservationType)
            {
                case "Prepaid_Reservation":
                    CalendarReservation.MinDate = DateTime.Now.AddDays(89); //  ön ödemeli rezervasyon için en az 90 gün önceden reservasyon yapılmalı
                    break;
                case "60Day_Reservation":
                    CalendarReservation.MinDate = DateTime.Now.AddDays(59);
                    break;
            }
            lbl_FirtReservationStartDate.Text = oldReservationStartDate.ToShortDateString();
            lbl_FirtReservationEndDate.Text = oldReservationEndDate.ToShortDateString();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            if (reservationType == "60Day_Reservation" && CalendarReservation.SelectionStart.ToShortDateString() != DateTime.Now.AddDays(60).ToShortDateString())
            {
                MessageBox.Show("Rezervasyonunuzun başlangıç tarihi " + DateTime.Now.AddDays(60).ToShortDateString() + " olmalıdır!!");
                return;
            }

            if (reservationType == "Prepaid_Reservation" && CalendarReservation.SelectionStart.ToShortDateString() != DateTime.Now.AddDays(90).ToShortDateString())
            {
                MessageBox.Show("Rezervasyonunuzun başlangıç tarihi " + DateTime.Now.AddDays(90).ToShortDateString() + " olmalıdır!!");
                return;
            }

            var addprice = new RoomBasePrice().GetPrice(CalendarReservation.SelectionStart) * 1.1M;
            var dialogresult = MessageBox.Show(addprice + " Ek ücretle rezervasyon gününü değiştirmek istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                var newReservationStartDate = CalendarReservation.SelectionStart;
                var newReservationEndDate = CalendarReservation.SelectionEnd;
                detail.ReservationStartDate = newReservationStartDate;
                detail.ReservationEndDate = newReservationEndDate;
                if (detail.DateUpdate())
                {
                    MessageBox.Show("Tarih başarıyla güncellendi" +
                                    "\nYeni rezervasyon başlangıç tarihi : " + newReservationStartDate.ToShortDateString()+
                                    "\nnYeni rezervasyon bitiş tarihi : " + newReservationEndDate.ToShortDateString());
                    detail.PriceUpdate(addprice);
                    // extra para çekme işlemi olcak
                }
                else
                {
                    detail.ReservationStartDate = oldReservationStartDate;
                    detail.ReservationEndDate = oldReservationEndDate;
                    MessageBox.Show("Tarih Güncelleme Başarısız");

                }
            }


            

        }
    }
}
