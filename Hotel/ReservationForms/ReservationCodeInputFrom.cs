using System.Windows.Forms;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Hotel.ReservationForms
{
    public partial class ReservationCodeInputFrom : KryptonForm
    {
        public ReservationCodeInputFrom()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            var reservation = new ReservationDetail().CheckReservationCode(textBox1.Text);
            if (reservation.Rows.Count != 0)
            {
                var frm = new ReservationInfoFrom(reservation);
                frm.Show();
            }
            else
            {
                MessageBox.Show(@"Rezervason kodu bulunamadı");
                // rezervason kodu bulunamadı
            }

        }
    }
}
