using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Admin.AdminForms
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click_1(object sender, EventArgs e)
        {
            AdminClasses.Admin admin = new AdminClasses.Admin();
            if (admin.Login(textUsername.Text, textPassword.Text))
            {
                MessageBox.Show(@"Başarıyla giriş yaptınız.");
                AdminDashboardForm frm = new AdminDashboardForm();
                frm.Show();
                return;
            }
            MessageBox.Show(@"Hatalı giriş.");
        }
    }
}
