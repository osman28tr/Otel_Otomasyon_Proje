namespace Otel_Rezervasyon.Worker.WorkerForms
{
    partial class CustomerListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Bill = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.lbl_PayPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_nightCount = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_roomNum = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_Bill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(296, 611);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pnl_Bill
            // 
            this.pnl_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Bill.Controls.Add(this.groupBox1);
            this.pnl_Bill.Controls.Add(this.lbl_Total);
            this.pnl_Bill.Controls.Add(this.lbl_nightCount);
            this.pnl_Bill.Controls.Add(this.lbl_endDate);
            this.pnl_Bill.Controls.Add(this.lbl_startDate);
            this.pnl_Bill.Controls.Add(this.lbl_roomNum);
            this.pnl_Bill.Controls.Add(this.lbl_name);
            this.pnl_Bill.Controls.Add(this.label6);
            this.pnl_Bill.Controls.Add(this.label5);
            this.pnl_Bill.Controls.Add(this.label4);
            this.pnl_Bill.Controls.Add(this.label3);
            this.pnl_Bill.Controls.Add(this.label2);
            this.pnl_Bill.Controls.Add(this.label1);
            this.pnl_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_Bill.Location = new System.Drawing.Point(364, 28);
            this.pnl_Bill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Bill.Name = "pnl_Bill";
            this.pnl_Bill.Size = new System.Drawing.Size(624, 567);
            this.pnl_Bill.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_PaymentDate);
            this.groupBox1.Controls.Add(this.lbl_PayPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(120, 384);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(389, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.Location = new System.Drawing.Point(157, 38);
            this.lbl_PaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(15, 20);
            this.lbl_PaymentDate.TabIndex = 14;
            this.lbl_PaymentDate.Text = "-";
            // 
            // lbl_PayPrice
            // 
            this.lbl_PayPrice.AutoSize = true;
            this.lbl_PayPrice.Location = new System.Drawing.Point(157, 71);
            this.lbl_PayPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PayPrice.Name = "lbl_PayPrice";
            this.lbl_PayPrice.Size = new System.Drawing.Size(15, 20);
            this.lbl_PayPrice.TabIndex = 13;
            this.lbl_PayPrice.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ödeme Miktarı  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ödeme Tarihi  :";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(241, 309);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(15, 20);
            this.lbl_Total.TabIndex = 11;
            this.lbl_Total.Text = "-";
            // 
            // lbl_nightCount
            // 
            this.lbl_nightCount.AutoSize = true;
            this.lbl_nightCount.Location = new System.Drawing.Point(241, 268);
            this.lbl_nightCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nightCount.Name = "lbl_nightCount";
            this.lbl_nightCount.Size = new System.Drawing.Size(15, 20);
            this.lbl_nightCount.TabIndex = 10;
            this.lbl_nightCount.Text = "-";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(241, 229);
            this.lbl_endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(15, 20);
            this.lbl_endDate.TabIndex = 9;
            this.lbl_endDate.Text = "-";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(241, 186);
            this.lbl_startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(15, 20);
            this.lbl_startDate.TabIndex = 8;
            this.lbl_startDate.Text = "-";
            // 
            // lbl_roomNum
            // 
            this.lbl_roomNum.AutoSize = true;
            this.lbl_roomNum.Location = new System.Drawing.Point(241, 143);
            this.lbl_roomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_roomNum.Name = "lbl_roomNum";
            this.lbl_roomNum.Size = new System.Drawing.Size(15, 20);
            this.lbl_roomNum.TabIndex = 7;
            this.lbl_roomNum.Text = "-";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(241, 103);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(15, 20);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Toplam Hesap :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kaldığı Gece Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gidiş Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geliş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Numarası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Bisque;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.Bisque;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Bisque;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.SandyBrown;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(592, 602);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.OverrideDefault.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Print.OverrideDefault.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Print.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Print.OverrideDefault.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Print.OverrideDefault.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Print.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Print.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Print.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Print.OverrideDefault.Border.Rounding = 20;
            this.btn_Print.OverrideDefault.Border.Width = 1;
            this.btn_Print.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Print.Size = new System.Drawing.Size(172, 49);
            this.btn_Print.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Print.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Print.StateCommon.Back.ColorAngle = 45F;
            this.btn_Print.StateCommon.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Print.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Print.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Print.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Print.StateCommon.Border.Rounding = 20;
            this.btn_Print.StateCommon.Border.Width = 1;
            this.btn_Print.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Print.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Print.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Print.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Print.StatePressed.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Print.StatePressed.Back.ColorAngle = 135F;
            this.btn_Print.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Print.StatePressed.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Print.StatePressed.Border.ColorAngle = 135F;
            this.btn_Print.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Print.StatePressed.Border.Rounding = 20;
            this.btn_Print.StatePressed.Border.Width = 1;
            this.btn_Print.StateTracking.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Print.StateTracking.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Print.StateTracking.Back.ColorAngle = 45F;
            this.btn_Print.StateTracking.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Print.StateTracking.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Print.StateTracking.Border.ColorAngle = 45F;
            this.btn_Print.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Print.StateTracking.Border.Rounding = 20;
            this.btn_Print.StateTracking.Border.Width = 1;
            this.btn_Print.TabIndex = 14;
            this.btn_Print.Values.Text = "Yazdır";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1016, 654);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.pnl_Bill);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerListForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerListForm";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_Bill.ResumeLayout(false);
            this.pnl_Bill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.Label lbl_PayPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_nightCount;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_roomNum;
        private System.Windows.Forms.Label lbl_name;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
    }
}