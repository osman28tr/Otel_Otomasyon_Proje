using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Otel_Rezervasyon.Worker.WorkerForms
{
    public partial class CustomerListForm : KryptonForm
    {
        private Customer.CustomerClasses.Customer customer;
        public CustomerListForm()
        {
            InitializeComponent();
            customer = new Customer.CustomerClasses.Customer();
        }
        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customer.GetCustomers();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customer.CustomerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);
            var rdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ReservationDetailId"].Value);
            var dt = customer.CustomerBill(rdId);

            lbl_name.Text = dt.Rows[0].ItemArray[0] +" "+ dt.Rows[0].ItemArray[1];
            lbl_roomNum.Text = dt.Rows[0].ItemArray[2].ToString();
            lbl_startDate.Text = Convert.ToDateTime(dt.Rows[0].ItemArray[3].ToString()).ToShortDateString();
            lbl_endDate.Text = Convert.ToDateTime(dt.Rows[0].ItemArray[4].ToString()).ToShortDateString();
            lbl_nightCount.Text = dt.Rows[0].ItemArray[5].ToString();
            lbl_Total.Text = dt.Rows[0].ItemArray[6].ToString();//toplam hesap
            lbl_PayPrice.Text = dt.Rows[0].ItemArray[6].ToString();//toplam hesap
            // 7:fatura basım tarihi
            try
            {
                lbl_PaymentDate.Text = Convert.ToDateTime(dt.Rows[0].ItemArray[8].ToString()).ToShortDateString(); 
                groupBox1.Visible = true;
            }
            catch
            {
                groupBox1.Visible = false;
            }

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            var doc = new PrintDocument();
            doc.PrintPage += doc_PrintPage;
            PrintPanel(pnl_Bill, doc);
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
            var grd = pnl_Bill;
            var bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            var bounds = e.PageSettings.PrintableArea;
            var factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

       
    }
}
