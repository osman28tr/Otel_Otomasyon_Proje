using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using Otel_Rezervasyon.Hotel.ReservationForms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class CustomerMainForm : KryptonForm
    {
        private CustomerClasses.Customer _customer;
        public CustomerMainForm(CustomerClasses.Customer c)
        {
            InitializeComponent();
            _customer = c;
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            var details = new ReservationDetail().GetReservationDetailForCustomer(_customer.CustomerId);
            if (details != null)
            { 
                // detaillar tabloda görünecek
                dataGridView1.DataSource = details;
            }
            else
            {
                dataGridView1.Visible = false;
                // rezervasyon yok
            }

        }

        private void btn_ResSettings_Click_1(object sender, EventArgs e)
        {
            var frm = new ReservationCodeInputFrom();
            frm.ShowDialog();
        }

        private void btn_MakeReservation_Click_1(object sender, EventArgs e)
        {
            var frm = new ReservationListForm(_customer);
            frm.Show();
        }
    }


}
