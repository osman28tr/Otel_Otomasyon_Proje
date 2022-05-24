using System.Data;
using System.Data.SqlClient;

namespace Otel_Rezervasyon.Worker.WorkerClasses
{
    internal class WorkerReport
    {
        private readonly Database.Database _db;

        public WorkerReport()
        {
            _db = new Database.Database();
        }

        public DataTable DailyArrivalReport()
        {
            //günlük gelenler raporu
            string query = @"select C.CustomerName,C.CustomerLastname,R.ReservationType,
                            RD.RoomId,RD.ReservationEndDate
                            from Reservation R inner join ReservationDetail RD
                            on R.ReservationId=RD.ReservationId inner join Customer C 
                            on RD.CustomerId=C.CustomerId
                            where RD.ReservationStartDate=CONVERT(date,getdate()) and RD.ReservationState = 1
                            order by C.CustomerName";

            var dataAdapter = new SqlDataAdapter(query,_db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable DailyOccupancyRatio()
        {
            // günlük doluluk raporu
            string query = @"select RD.RoomId,
                            'Ayrılış Tarihi'=
                            CASE 
                            	WHEN RD.ReservationStartDate = CONVERT(Date,DATEADD(DAY,-1,GETDATE())) then RD.ReservationEndDate
                            	else null
                            	end,
                            'Müşteri Adı' = 
                            Case
                            	When RD.ReservationEndDate = CONVERT(date,getdate()) then '*' + C.CustomerName + ' ' + C.CustomerLastname
                            	else C.CustomerName + ' ' + C.CustomerLastname
                            	end
                            from Reservation R inner join ReservationDetail RD
                            on R.ReservationId=RD.ReservationId inner join Customer C 
                            on RD.CustomerId=C.CustomerId
                            where convert(date,GETDATE()) >= RD.ReservationStartDate and RD.ReservationEndDate >= convert(date,GETDATE())
                            and RD.ReservationState = 1
                            order by RD.RoomId";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable EmailSendCustomers()
        {
            // 60 gün önceden rezervasyon yapmış olanlar email gönderilecek müşterileri listeler 
            string query = @"SELECT c.CustomerEmail as 'Müşteri e-posta adresi', c.CustomerName + ' ' + c.CustomerLastname as 'Müşteri Adı Soyadı'
                             FROM ReservationDetail rd inner join Customer c 
                             on c.CustomerId = rd.CustomerId inner join Reservation r
                             on r.ReservationId = rd.ReservationId
                             WHERE CONVERT(date,GETDATE()) 
                             between (DATEADD(DAY,-45,rd.ReservationStartDate)) and DATEADD(DAY,-30,rd.ReservationStartDate) 
                             and rd.PaymentStatus = 0 
                             and rd.ReservationState = 1
                             and r.ReservationType = '60Day_Reservation'";

            var dataAdapter = new SqlDataAdapter(query, _db.Baglanti());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}
