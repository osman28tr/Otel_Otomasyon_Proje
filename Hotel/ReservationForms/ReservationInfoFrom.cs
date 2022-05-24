using System;
using System.Data;
using System.Windows.Forms;
using Otel_Rezervasyon.Customer.CustomerClasses;
using Otel_Rezervasyon.Customer.CustomerForms;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Hotel.ReservationForms
{
    public partial class ReservationInfoFrom : KryptonForm
    {
        private readonly DataTable dt;
        private int detailId;
        private ReservationDetail detail;
        public ReservationInfoFrom(DataTable dataTable)
        {
            InitializeComponent();
            dt = dataTable;
            detail = new ReservationDetail();
        }

        private void ReservationInfoFrom_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            var isCanceled =
                !Convert.ToBoolean(dataGridView1.CurrentRow.Cells[dataGridView1.CurrentRow.Cells.Count - 1].Value);
            if (isCanceled)
            {
                MessageBox.Show(@"Bu rezervasyon iptal edilmiştir");
                this.Close();
                return;
            }
            detailId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ReservationDetailId"].Value.ToString());
            detail.ReservationDetailId = detailId;
            detail.ReservationId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ReservationId"].Value.ToString());
            detail.CustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerId"].Value.ToString());
            detail.PaymentStatus = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["PaymentStatus"].Value);
            var paymentdate = dataGridView1.CurrentRow.Cells["PaymentDate"].Value;
            detail.PaymentDate = Convert.ToDateTime(paymentdate != DBNull.Value ? paymentdate : null);
            detail.ReservationStartDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["ReservationStartDate"].Value);
            detail.ReservationEndDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["ReservationEndDate"].Value);

            if (detail.PaymentStatus)
            {
                btn_Pay.Visible = false;
            }

        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (!detail.PaymentStatus)
            {
                var frm = new PaypentForm(detail);
                frm.ShowDialog();
            }
            else
                MessageBox.Show(@"Bu rezervasyon zaten ödenmiştir");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var card = new CreditCard().GetInformationsForCustomer(detail.CustomerId);
            if ((detail.GetReservationType() is "Classic_Reservation" or "Incentive_Reservation") && detail.ReservationStartDate.Day - DateTime.Now.Day <= 3)
            {
                MessageBox.Show("UYARI !!\nEğer bu rezervasyonu iptal ederseniz;" +
                                "\nKart sahibi : "+ card.CardOwn +
                                "\nKart numarası : "+ card.CardNumber +
                                "\nKart son kullanım tarihi : "+ card.CardExpiryDate.ToShortDateString() +
                                "\nKart tipi : " + card.CardType+
                                "\nbilgilerine sahip kartınızdan ceza fiyatı çekilecektir.");
            }

            if (detail.GetReservationType() == "Prepaid_Reservation")
            {
                MessageBox.Show("UYARI !!\nBu rezervasyonda Geri ödeme yoktur.");
            }
            var dialogResult = MessageBox.Show(@"Rezervasonu iptal etmek istediğinize emin misiniz ?", "Onay",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                detail.ReservationCancel();
                MessageBox.Show(@"Rezervasyonunuz iptal edilmiştir.");
                dataGridView1.DataSource = dt;
                // iptal edilecek
            }
        }

        private void btn_ChangeDate_Click(object sender, EventArgs e)
        {
            var frm = new ReservationChangeDateForm(detail);
            frm.ShowDialog();
        }
    }
}
