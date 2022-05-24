using System;
using System.Data;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Customer.CustomerClasses
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public bool CustomerGender { get; set; }
        public DateTime CustomerBirthDay { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }

        private Database.Database _db;

        public Customer(string name, string lastname, bool gender)
        {
            CustomerName = name;
            CustomerLastname = lastname;
            CustomerGender = gender;
        }

        public Customer()
        {
            _db = new Database.Database();

        }

        public void SaveCustomer()
        {
            _db = new Database.Database();
            var AddString = "Insert into Customer(CustomerName,CustomerLastname,CustomerGender,CustomerPhoneNumber,CustomerBirthDay,CustomerEmail) " +
                            "VALUES(@CustomerName , @CustomerLastname , @CustomerGender , @CustomerPhoneNumber, @CustomerBirthDay, @CustomerEmail);" +
                            "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(AddString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@CustomerName", this.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerLastname", this.CustomerLastname);
            cmd.Parameters.AddWithValue("@CustomerGender", this.CustomerGender);
            cmd.Parameters.AddWithValue("@CustomerPhoneNumber", this.CustomerPhoneNumber);
            cmd.Parameters.AddWithValue("@CustomerBirthDay", this.CustomerBirthDay);
            if (CustomerEmail != null)
            {
                cmd.Parameters.AddWithValue("@CustomerEmail", this.CustomerEmail);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CustomerEmail", DBNull.Value);
            }
            CustomerId = Convert.ToInt32(cmd.ExecuteScalar());
            _db.Baglanti().Close();
        }

        public void RegisterCustomer()
        {
            _db = new Database.Database();
            var AddString = "Insert into Customer(CustomerName,CustomerLastname,CustomerGender,CustomerPhoneNumber,CustomerBirthDay,CustomerEmail,CustomerPassword) " +
                            "VALUES(@CustomerName , @CustomerLastname , @CustomerGender , @CustomerPhoneNumber, @CustomerBirthDay, @CustomerEmail,@CustomerPassword);" +
                            "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(AddString, _db.Baglanti());
            cmd.Parameters.AddWithValue("@CustomerName", this.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerLastname", this.CustomerLastname);
            cmd.Parameters.AddWithValue("@CustomerGender", this.CustomerGender);
            cmd.Parameters.AddWithValue("@CustomerPhoneNumber", this.CustomerPhoneNumber);
            cmd.Parameters.AddWithValue("@CustomerBirthDay", this.CustomerBirthDay);
            cmd.Parameters.AddWithValue("@CustomerEmail", this.CustomerEmail);
            cmd.Parameters.AddWithValue("@CustomerPassword", this.CustomerPassword);

            CustomerId = Convert.ToInt32(cmd.ExecuteScalar());
            _db.Baglanti().Close();
        }

        public bool Login(string email, string password)
        {
            _db = new Database.Database();
            string getPriceQuery = $"CustomerLogin '{email}' , '{password}'";

            var cmd = new SqlCommand(getPriceQuery, _db.Baglanti());
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CustomerId = Convert.ToInt32(reader[0].ToString());
                CustomerName = reader[1].ToString();
                CustomerLastname = reader[2].ToString();
                CustomerPhoneNumber = reader[3].ToString();
                CustomerBirthDay = Convert.ToDateTime(reader[4].ToString());
                return true;
            }

            return false;
        }

        public DataTable GetCustomers()
        {
            string allCustomersQuery = @"select C.CustomerId,RD.ReservationDetailId,
                                         C.CustomerName + ' ' + C.CustomerLastname as 'Adı ve Soyadı'
                                         from ReservationDetail RD inner join Customer C
                                         on RD.CustomerId = C.CustomerId 
                                         WHERE RD.ReservationEndDate = CONVERT(DATE,GETDATE())";
            var dataAdapter = new SqlDataAdapter(allCustomersQuery, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();
            return dt;
        }

        public DataTable CustomerBill(int rdId)
        {
            string allCustomersQuery = 
                $@"select C.CustomerName,C.CustomerLastname,RD.RoomId,
                RD.ReservationStartDate,RD.ReservationEndDate,
                DATEDIFF(day,RD.ReservationStartDate,RD.ReservationEndDate) as 'Kaldigi Gece Sayisi', 
                R.ReservationPrice as 'toplam hesap',
                CONVERT(DATE,GETDATE()) as 'fatura basim tarihi',
                'Odeme tarihi' = Case 
                When R.ReservationType = '60Day_Reservation' OR R.ReservationType = 'Prepaid_Reservation'
                then Convert(date,RD.PaymentDate)
                else null
                end
                from Reservation R inner join ReservationDetail RD
                on R.ReservationId=RD.ReservationId inner join Customer C
                on RD.CustomerId=C.CustomerId
                where C.CustomerId={CustomerId} and RD.ReservationState = 1 and RD.ReservationDetailId = {rdId}";
            var dataAdapter = new SqlDataAdapter(allCustomersQuery, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();
            return dt;
        }
    }
}
