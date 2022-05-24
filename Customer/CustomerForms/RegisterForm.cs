using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Customer.CustomerForms
{
    public partial class RegisterForm : KryptonForm
    {
        public RegisterForm()
        {
            InitializeComponent();
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
                CustomerPhoneNumber = phoneNumber,
                CustomerEmail = textEmail.Text,
                CustomerPassword = textPassword.Text
            };
            customer.RegisterCustomer();
        }
    }
}
