using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Customer.CustomerClasses;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class PaypentForm : KryptonForm
    {
        private ReservationDetail _reservationDetail;
        private string reservationType;
        public PaypentForm(ReservationDetail _reservationDetail)
        {
            InitializeComponent();
            this._reservationDetail = _reservationDetail;
        }

        public PaypentForm(string reservationType, ReservationDetail _reservationDetail)
        {
            InitializeComponent();
            this._reservationDetail = _reservationDetail;
            this.reservationType = reservationType;
        }

        private void PaypentForm_Load(object sender, EventArgs e)
        {
            if (reservationType is "Classic_Reservation" or "Incentive_Reservation")
            {
                BtnBuy.Text = "Bilgirleri kaydet";
            }
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
            if (reservationType is "Classic_Reservation" or "Incentive_Reservation")
            {
                var dialogResult = MessageBox.Show(@"Kredi kartı bilgilerinizi onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CardSave();
                    MessageBox.Show(@"Kredi kartı bilgileriniz başarıyla kaydedilmiştir.");

                    this.Hide();
                }
            }
            else
            {
                var dialogResult = MessageBox.Show(@"Ödeme işlemini tamamlamak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _reservationDetail.PaymentDate = DateTime.Now;
                    _reservationDetail.PaymentStatus = true;
                    _reservationDetail.PaymentUpdate();
                    CardSave();

                    //rezervason ve ödeme işlemi tamamlama
                    MessageBox.Show("Ödeme işlemi tamamlanmıştır.");
                    this.Close();
                }
            }
        }

        private void CardSave()
        {
            var card = new CreditCard();
            var c = TxtCardNumber.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            card.CardOwn = TxtCardName.Text;
            card.CardNumber = Convert.ToDecimal(c[0] + c[1] + c[2] + c[3]);
            card.CardExpiryDate = Convert.ToDateTime("1." + CboxAA.Text + ".20" + CboxYY.Text);
            card.CardType = CboxCardType.Text;
            card.CustomerId = _reservationDetail.CustomerId;
            card.CreditCardSave();
        }


    }
}
