using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Otel_Rezervasyon.Worker.WorkerClasses;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Worker.WorkerForms
{
    public partial class WorkerDashboardForm : KryptonForm
    {
        public WorkerDashboardForm()
        {
            InitializeComponent();
        }

        private void btn_GunlukGelenler_Click(object sender, EventArgs e)
        {
            
            var report = new WorkerReport();
            dataGridView1.DataSource = report.DailyArrivalReport();
            dataGridView1.CellDoubleClick -= DataGridView1OnCellDoubleClick;


        }

        private void btn_GunlukDoluluk_Click(object sender, EventArgs e)
        {
            var report = new WorkerReport();
            dataGridView1.DataSource = report.DailyOccupancyRatio();
            dataGridView1.CellDoubleClick -= DataGridView1OnCellDoubleClick;
        }

        private void btn_CustomerBill_Click(object sender, EventArgs e)
        {
            var frm = new CustomerListForm();
            frm.Show();
        }

        private void btn_print_Click(object sender, EventArgs e)
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

        private void btn_mail_Click(object sender, EventArgs e)
        {
            var report = new WorkerReport();
            dataGridView1.DataSource = report.EmailSendCustomers();
            dataGridView1.CellDoubleClick += DataGridView1OnCellDoubleClick;
        }

        private void DataGridView1OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dialogResult = MessageBox.Show($"Bilgileri : " +
                                               $"\n\tEposta : {dataGridView1.Rows[e.RowIndex].Cells["Müşteri e-posta adresi"].Value} " +
                                               $"\n\tAdı soyadı : {dataGridView1.Rows[e.RowIndex].Cells["Müşteri Adı Soyadı"].Value} " +
                                               $"\nolan müşteriye eposta göndermek ister misiniz ?"
                , "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(@"Eposta Gönderildi");
            }
        }
    }
}
