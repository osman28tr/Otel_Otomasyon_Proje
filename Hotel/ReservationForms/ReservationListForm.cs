using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Hotel.ReservationForms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class ReservationListForm : KryptonForm
    {
        private CustomerClasses.Customer _customer;
        public ReservationListForm()
        {
            InitializeComponent();
        }
        public ReservationListForm(CustomerClasses.Customer c)
        {
            InitializeComponent();
            _customer = c;
        }

        private void btn_Prepaid_Reservation_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                var frm = new ReservationForm(_customer.CustomerId, "Prepaid_Reservation");
                frm.Show();
                return;
            }
            var ınfoForm = new CustomerInfoForm("Prepaid_Reservation");
            ınfoForm.Show();
            //kulanıcı bilgi ekranı -> ödeme ekranı -> ödeme onaylama
        }

        private void btn_60Day_Reservation_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                var frm = new ReservationForm(_customer.CustomerId, "60Day_Reservation");
                frm.Show();
                return;

            }
            var ınfoForm = new CustomerInfoForm("60Day_Reservation");
            ınfoForm.Show();
            //kulanıcı bilgi ekranı (email gerekli)
            //ilk 15 gün bildirim yok.
            //Konaklama günlerinden 45 gün önce müşterilere
            //rezervasyon ücretlerinin 15 gün içinde ödenmesini,
            //aksi takdirde rezervasyonlarının iptal edileceğini
            //bildiren bir e-posta gönderilir
            //Görevli her sabah bu e - posta mesajlarını göndermelidir.
        }

        private void btn_Classic_Reservation_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                var frm = new ReservationForm(_customer.CustomerId, "Classic_Reservation");
                frm.Show();
                return;

            }
            var ınfoForm = new CustomerInfoForm("Classic_Reservation");
            ınfoForm.Show();
            //Bu rezervasyonda, müşteriler konaklamalarının sonunda ödemeyi yaparlar.
            //Bununla beraber, rezervasyonu yaptıkları zaman kredi
            //kartı numaralarını vermek zorundalar.
            //Eğer konaklamalarına 3 günden daha az bir
            //zaman kala rezervasyonu iptal ederlerse veya konaklamalarının ilk günü otele
            //gelmezlerse kartlarından ceza fiyatı çekilir.
        }

        private void btn_Incentive_Reservation_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                var frm = new ReservationForm(_customer.CustomerId, "Incentive_Reservation");
                frm.Show();
                return;

            }
            var ınfoForm = new CustomerInfoForm("Incentive_Reservation");
            ınfoForm.Show();
        }
    }
}
