using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Hotel.ReservationForms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class CustomerInfoForm : KryptonForm
    {
        private readonly string resType;  
        public CustomerInfoForm(string resType)
        {
            InitializeComponent();
            this.resType = resType;
        }

        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            if (resType is "60Day_Reservation")
            {
                labelEmail.Visible = true;
                textEmail.Visible = true;
            }
        }

        private void btn_Confirm_Click_1(object sender, EventArgs e)
        {
            string Name = textName.Text;
            string Lastname = textLastname.Text;
            bool gender = comboBoxGender.SelectedIndex == 1;
            string phoneNumber = textPhoneNum.Text;

            var customer = new CustomerClasses.Customer(Name, Lastname, gender)
            {
                CustomerBirthDay = CalendarBirth.SelectionStart,
                CustomerPhoneNumber = phoneNumber
            };

            if (resType == "60Day_Reservation") // email check edilcek
            {
                if (textEmail.Text.Length == 0)
                {
                    MessageBox.Show(@"Email adresiniz boş olamaz");
                    return;
                }
                customer.CustomerEmail = textEmail.Text;
            }



            customer.SaveCustomer();

            ReservationForm frm = new ReservationForm(customer.CustomerId, resType);
            frm.Show();
        }
    }
}
