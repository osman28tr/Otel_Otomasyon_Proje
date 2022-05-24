using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Worker.WorkerForms
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            var Username = textUsername.Text;
            var password = textPassword.Text;
            var W = new WorkerClasses.Worker();
            if (!W.Login(Username, password))
            {
                MessageBox.Show(@"Eposta adresiniz veya parolanız hatalı lütfen tekrar deneyin1");
                return;
            }
            this.Hide();
            MessageBox.Show(@"Başarıyla giriş yaptınız.");
            WorkerDashboardForm reportForm = new WorkerDashboardForm();
            reportForm.Show();
        }
    }
}
