using System;
using System.Data;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Customer.CustomerClasses
{
    internal class CreditCard
    {
        private int CardId { get; set; }
        public int CustomerId { get; set; }
        public decimal CardNumber { get; set; }
        public string CardOwn { get; set; }
        public DateTime CardExpiryDate { get; set; }
        public string CardType { get; set; }

        private Database.Database _db;

        public CreditCard()
        {
            _db = new Database.Database();

        }

        public void CreditCardSave()
        {
            string query = "INSERT into CreditCard (CustomerId , CardNumber , CardOwn , CardExpiryDate , CardType) " +
                           "Values(@CustomerId, @CardNumber, @CardOwn, @CardExpiryDate, @CardType)";

            SqlCommand cmd = new SqlCommand(query, _db.Baglanti());
            cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
            cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
            cmd.Parameters.AddWithValue("@CardOwn", CardOwn);
            cmd.Parameters.AddWithValue("@CardExpiryDate", CardExpiryDate);
            cmd.Parameters.AddWithValue("@CardType", CardType);
            cmd.ExecuteNonQuery();
        }

        public CreditCard GetInformationsForCustomer(int customerId)
        {
            this.CustomerId = customerId;
            var query =
                "SELECT CardNumber , CardOwn , CardExpiryDate , CardType " +
                "FROM CreditCard " +
                "WHERE CustomerId = " + this.CustomerId;

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            _db.Baglanti().Close();
            this.CardNumber = Convert.ToDecimal(dt.Rows[0].ItemArray[0].ToString());
            this.CardOwn = dt.Rows[0].ItemArray[1].ToString();
            this.CardExpiryDate = Convert.ToDateTime(dt.Rows[0].ItemArray[2].ToString());
            this.CardType = dt.Rows[0].ItemArray[3].ToString();
            return this;
        }
    }
}
