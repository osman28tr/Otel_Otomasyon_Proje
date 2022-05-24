using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Reservation.ReservationClasses;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class PaypentForm : Form
    {
        private ReservationDetail reservationDetail;
        private int CustomerId;
        public PaypentForm(int CustomerId)
        {
            InitializeComponent();
            this.reservationDetail = new ReservationDetail();
            this.CustomerId = CustomerId;
        }

        private void TxtCardName_TextChanged(object sender, EventArgs e)
        {
            LblCardName.Text = TxtCardName.Text;
            if (TxtCardName.Text.Length == 0)
            {
                LblCardName.Text = "Kart sahibi";
            }
        }

        private void CboxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxCardType.Text == "Visa")
            {
                PicVisa_Logo.Visible = true;
                PicMaster_Logo.Visible = false;
            }
            else
            {
                PicVisa_Logo.Visible = false;
                PicMaster_Logo.Visible = true;
            }
        }

        private void TxtCardNumber_KeyUp(object sender, KeyEventArgs e)
        {
            LblCardNumber.Text = TxtCardNumber.Text;
            if (e.KeyCode == Keys.Back)
            {
                LblCardNumber.Text = TxtCardNumber.Text;

            }
            else
            {
                if (LblCardNumber.Text.Length == 4 || LblCardNumber.Text.Length == 9
                    || LblCardNumber.Text.Length == 14)
                {
                    LblCardNumber.Text += " ";
                    TxtCardNumber.Text += " ";
                    TxtCardNumber.SelectionStart = TxtCardNumber.Text.Length;
                }
                LblCardNumber.Text = TxtCardNumber.Text;

            }
        }

        private void CboxAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblDateAA.Text = Convert.ToInt32(CboxAA.Text) < 10 ? "0" + CboxAA.Text : CboxAA.Text;
        }

        private void CboxYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblDateYY.Text = CboxYY.Text;
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Ödeme işlemini tamamlamak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                reservationDetail.CustomerId = CustomerId;
                reservationDetail.PaymentStatus = true;
                reservationDetail.PaymentDate = DateTime.Now;
                
                
                //rezervason ve ödeme işlemi tamamlama
            }
        }
    }
}
