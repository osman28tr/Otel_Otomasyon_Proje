using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click_1(object sender, EventArgs e)
        {
            var email = textEmail.Text;
            var password = textPassword.Text;
            var c = new CustomerClasses.Customer();
            if (!c.Login(email, password))
            {
                MessageBox.Show(@"Eposta adresiniz veya parolanız hatalı lütfen tekrar deneyin1");
                return;
            }
            c.CustomerEmail = email;
            c.CustomerPassword = password;
            this.Hide();
            MessageBox.Show(@"Başarıyla giriş yaptınız.");
            var frm = new CustomerMainForm(c);
            frm.Show();
            //dashboard ekranı gelecek
            // dashboard 'dan -> iptal etme
            // & rezervasyon yapma
            // & daha önce yaptığı rezervasyonları görüp ödemelerini yapabilcek
            // & rezervasyon günü değiştirebilcek.
        }

    }
}
