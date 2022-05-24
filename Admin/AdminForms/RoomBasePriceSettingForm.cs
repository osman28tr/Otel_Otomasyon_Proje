using System;
using System.Windows.Forms;
using Otel_Rezervasyon.Hotel.ReservationClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Admin.AdminForms
{
    public partial class RoomBasePriceSettingForm : KryptonForm
    {
        private RoomBasePrice roomBasePrice;
        public RoomBasePriceSettingForm()
        {
            InitializeComponent();
            roomBasePrice = new RoomBasePrice();
        }

        private void RoomBasePriceSettingForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = roomBasePrice.GetPrices();
            monthCalendar1.MinDate = DateTime.Now.AddYears(1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            monthCalendar1.SelectionStart = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["StartDate"].Value.ToString());
            monthCalendar1.SelectionEnd = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["EndDate"].Value.ToString());
            roomBasePrice.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            RoomBasePrice BasePrice = new RoomBasePrice();
            BasePrice.StartDate = monthCalendar1.SelectionStart;
            BasePrice.EndDate = monthCalendar1.SelectionEnd;
            BasePrice.Price = Convert.ToDecimal(textBox1.Text);
            BasePrice.SavePrice();
            MessageBox.Show("Başarıyla Eklendi");

            dataGridView1.DataSource = roomBasePrice.GetPrices();
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            roomBasePrice.Price = Convert.ToDecimal(textBox1.Text);
            roomBasePrice.StartDate = monthCalendar1.SelectionStart;
            roomBasePrice.EndDate = monthCalendar1.SelectionEnd;
            roomBasePrice.UpdatePrice();
            MessageBox.Show("Başarıyla Güncellendi");
            dataGridView1.DataSource = roomBasePrice.GetPrices();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            roomBasePrice.DeletePrice();
            MessageBox.Show("Başarıyla silindi");
            dataGridView1.DataSource = roomBasePrice.GetPrices();
        }
    }
}
