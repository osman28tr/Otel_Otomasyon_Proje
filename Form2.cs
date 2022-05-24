using Otel_Rezervasyon.Hotel.ReservationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Reservation reservation = new Reservation();
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reservation.BeklenenDoluluk();
            double odaSayisi = 0;
            int odaSayac = reservation.BeklenenDoluluk().Rows.Count;
            for (int i = 1; i <= odaSayac; i++)
            {
                odaSayisi = odaSayisi + Convert.ToInt32(reservation.BeklenenDoluluk().Rows[i - 1][0].ToString());
            }
            MessageBox.Show("toplam oda doluluk orani: %" + Math.Round((odaSayisi/45)*100));
        }
    }
}
