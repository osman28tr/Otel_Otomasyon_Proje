using System;
using System.Linq;
using System.Windows.Forms;
using Otel_Rezervasyon.Customer.CustomerForms;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Hotel.ReservationForms
{
    public partial class ReservationForm : KryptonForm
    {
        public ReservationDetail reservationDetail;
        public Reservation reservation;
        public string ReservationType { get; set; }
        private readonly int CustomerId;
        public ReservationForm(int CustomerId, string ReservationType)
        {
            InitializeComponent();
            reservationDetail = new ReservationDetail();
            reservation = new Reservation();
            this.CustomerId = CustomerId;
            this.ReservationType = ReservationType;
            reservationDetail.CustomerId = CustomerId;

        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            switch (ReservationType)
            {
                case "Prepaid_Reservation":
                    CalendarReservation.MinDate = DateTime.Now.AddDays(89); //  ön ödemeli rezervasyon için en az 90 gün önceden reservasyon yapılmalı
                    break;
                case "60Day_Reservation":
                    CalendarReservation.MinDate = DateTime.Now.AddDays(59);
                    break;
                case "Classic_Reservation":
                    CalendarReservation.MinDate = DateTime.Now;
                    break;
                case "Incentive_Reservation":
                    CalendarReservation.MinDate = DateTime.Now;
                    break;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Rezervasyonu onaylamak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Confirm();
                if (reservationDetail.ReservationCode == null) return;
                MessageBox.Show("Rezervasyonunuz Başarıyla oluşturulmuştur.\nRezervasyon KODUNUZ : " +
                                reservationDetail.ReservationCode);
                if (ReservationType == "60Day_Reservation")
                {
                    var dialog = MessageBox.Show(@"Ödemeyi şimdi yapmak ister misiniz ?", "Onay",
                        MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.No)
                    {
                        this.Close();
                        return;
                    }
                }
                var frm = new PaypentForm(reservation.ReservationType, reservationDetail);
                frm.Show();

                if (reservation.ReservationType == "Classic_Reservation" || reservation.ReservationType == "Prepaid_Reservation")
                {
                    frm.Closing += (o, args) =>
                    {
                        if (reservationDetail.PaymentStatus == false)
                        {
                            var closeResult = MessageBox.Show((reservation.ReservationType == "Prepaid_Reservation")
                                ? "Bu rezervasyon tipinde ödemenizi rezervasyondan hemen sonra yapmak zorundasınız.\nAksi halde rezervasyon iptal edilir.\nYine de çıkış yapmak ister misiniz ?"
                                : "Bu rezervasyon tipinde kredi kartı bilgilerinizi rezervasyondan hemen sonra vermek zorundasınız.\nAksi halde rezervasyon iptal edilir.\nYine de çıkış yapmak ister misiniz ?", "Onay", MessageBoxButtons.YesNo);

                            if (closeResult == DialogResult.Yes)
                            {
                                MessageBox.Show("Rezervasyon iptal edilmiştir.");
                                reservationDetail.ReservationCancel();
                                args.Cancel = false;
                            }
                            else
                            {
                                args.Cancel = true;
                            }
                        }

                    };
                }


                this.Close();
                return;
            }

        }
        private void Confirm()
        {
            if (ReservationType == "60Day_Reservation" && CalendarReservation.SelectionStart.ToShortDateString() != DateTime.Now.AddDays(60).ToShortDateString())
            {
                MessageBox.Show(@"Rezervasyonunuzun başlangıç tarihi " + DateTime.Now.AddDays(60).ToShortDateString() + " olmalıdır!!");
                return;
            }

            reservation.ReservationType = ReservationType;
            reservation.ReservationLastPaymentDate = DateTime.Now;
            reservationDetail.CustomerId = CustomerId;
            reservationDetail.ReservationStartDate = CalendarReservation.SelectionStart;
            reservationDetail.ReservationEndDate = CalendarReservation.SelectionEnd;
            reservation.ReservationPrice = reservation.GetPrice(reservationDetail.ReservationStartDate, reservationDetail.ReservationEndDate);
            reservation.AddReservation();
            reservationDetail.ReservationId = reservation.ReservationId;
            reservationDetail.ReservationCode = GetRandomHexNumber(8);
            reservationDetail.Save();
        }

        private static Random _random;
        public static string GetRandomHexNumber(int digits)
        {
            _random = new Random();
            var buffer = new byte[digits / 2];
            _random.NextBytes(buffer);
            var result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + _random.Next(16).ToString("X");
        }
    }
}
