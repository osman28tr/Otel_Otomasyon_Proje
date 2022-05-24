using System.Data.SqlClient;

namespace Otel_Rezervasyon.Worker.WorkerClasses
{
    internal class Worker
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private Database.Database _db;

        public bool Login(string Username, string Password)
        {
            _db = new Database.Database();
            var getPriceQuery = $@"WorkerLogin '{Username}','{Password}'";

            var cmd = new SqlCommand(getPriceQuery, _db.Baglanti());
          
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Username = Username;
                this.Password = Password;
                return true;
            }

            return false;
        }
    }
}
