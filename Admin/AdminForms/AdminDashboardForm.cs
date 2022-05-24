using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Otel_Rezervasyon.Admin.AdminClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Admin.AdminForms
{
    public partial class AdminDashboardForm : KryptonForm
    {
        private AdminReport _report;
        public AdminDashboardForm()
        {
            InitializeComponent();
            _report = new AdminReport();
        }

        private void btn_ExpectedOccupancyReport_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            dataGridView1.DataSource = _report.ExpectedOccupancyReport();
            textBox1.Text = "30 günlük ortalama doluluk oranı : " + (Convert.ToSingle(dataGridView1.Rows.Count) / 45);
        }

        private void btn_ExpectedRoomIncomeReport_Click_1(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox1.Visible = true;

            dataGridView1.DataSource = _report.ExpectedRoomIncomeReport();
            float total = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Sum(dataGridViewRow => Convert.ToSingle(dataGridViewRow.Cells["Toplam Gelir"].Value.ToString()));
            textBox1.Text = "Toplam Gelir : " + total;

            textBox2.Text = "Ortalama Gelir : " + Convert.ToSingle(total) / Convert.ToSingle(dataGridView1.Rows.Count);
        }

        private void btn_IncentiveReport_Click_1(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox1.Visible = false;
            dataGridView1.DataSource = _report.IncentiveReport();
        }

        private void btn_RoomPriceSetting_Click_1(object sender, EventArgs e)
        {
            RoomBasePriceSettingForm frm = new RoomBasePriceSettingForm();
            frm.ShowDialog();
        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            var doc = new PrintDocument();
            doc.PrintPage += doc_PrintPage;
            PrintPanel(panel1, doc);
        }

        private void PrintPanel(Panel pnl, PrintDocument printDocument1)
        {
            var myPrintDialog = new PrintDialog();
            var memoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImage, pnl.ClientRectangle);
            if (myPrintDialog.ShowDialog() == DialogResult.OK)
            {
                myPrintDialog.Document = printDocument1;
                printDocument1.PrintController = new StandardPrintController();
                printDocument1.Print();
            }
            printDocument1.Dispose();
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var grd = panel1;
            var bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            var bounds = e.PageSettings.PrintableArea;
            var factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        
    }
}
