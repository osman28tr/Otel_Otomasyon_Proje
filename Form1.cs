using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Customer.CustomerForms;
using Otel_Rezervasyon.Hotel.ReservationForms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Custmer_Click(object sender, EventArgs e)
        {
            // rezervasyon yapılacak yer
            var frm = new ReservationListForm();
            frm.Show();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            frm.ShowDialog();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            var frm = new ReservationCodeInputFrom();
            frm.ShowDialog();
        }

        private void btn_LoginWorker_Click(object sender, EventArgs e)
        {
            var frm = new Worker.WorkerForms.LoginForm();
            frm.ShowDialog();
        }

        private void btn_LoginAdmin_Click(object sender, EventArgs e)
        {
            Admin.AdminForms.LoginForm frm = new Admin.AdminForms.LoginForm();
            frm.ShowDialog();
        }
    }
}
