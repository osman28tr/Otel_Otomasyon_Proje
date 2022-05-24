using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon.Reservation.ReservationForms
{
    public partial class ReservationForm : Form
    {
        private int reservationId;
        public ReservationForm(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

            var ReservationType = new ReservationClasses.Reservation().GetReservationType(reservationId);
            if (ReservationType == "Prepaid_Reservation")
            {
                var ReservationStartDate = CalendarReservation.SelectionStart;
                var ReservationEndDate = CalendarReservation.SelectionEnd;
            }
            
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
