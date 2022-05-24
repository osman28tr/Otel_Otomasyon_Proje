namespace Otel_Rezervasyon.Customer.CustomerForms
{
    partial class PaypentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaypentForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboxYY = new System.Windows.Forms.ComboBox();
            this.CboxAA = new System.Windows.Forms.ComboBox();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.PicMaster_Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LblDateYY = new System.Windows.Forms.Label();
            this.LblCardNumber = new System.Windows.Forms.Label();
            this.LblCardName = new System.Windows.Forms.Label();
            this.LblDateAA = new System.Windows.Forms.Label();
            this.PicVisa_Logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCardName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCardNumber = new System.Windows.Forms.TextBox();
            this.CboxCardType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicMaster_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVisa_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.YellowGreen;
            this.label5.Location = new System.Drawing.Point(96, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kart Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(96, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 32;
            // 
            // CboxYY
            // 
            this.CboxYY.BackColor = System.Drawing.SystemColors.Control;
            this.CboxYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CboxYY.FormattingEnabled = true;
            this.CboxYY.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.CboxYY.Location = new System.Drawing.Point(147, 248);
            this.CboxYY.Name = "CboxYY";
            this.CboxYY.Size = new System.Drawing.Size(46, 26);
            this.CboxYY.TabIndex = 31;
            this.CboxYY.SelectedIndexChanged += new System.EventHandler(this.CboxYY_SelectedIndexChanged);
            // 
            // CboxAA
            // 
            this.CboxAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CboxAA.FormattingEnabled = true;
            this.CboxAA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CboxAA.Location = new System.Drawing.Point(100, 248);
            this.CboxAA.Name = "CboxAA";
            this.CboxAA.Size = new System.Drawing.Size(41, 26);
            this.CboxAA.TabIndex = 30;
            this.CboxAA.SelectedIndexChanged += new System.EventHandler(this.CboxAA_SelectedIndexChanged);
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBuy.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnBuy.Location = new System.Drawing.Point(329, 344);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(197, 45);
            this.BtnBuy.TabIndex = 29;
            this.BtnBuy.Text = "Ödemeyi Tamamla";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // PicMaster_Logo
            // 
            this.PicMaster_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PicMaster_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PicMaster_Logo.Image")));
            this.PicMaster_Logo.Location = new System.Drawing.Point(232, 151);
            this.PicMaster_Logo.Name = "PicMaster_Logo";
            this.PicMaster_Logo.Size = new System.Drawing.Size(66, 44);
            this.PicMaster_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMaster_Logo.TabIndex = 13;
            this.PicMaster_Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LblDateYY);
            this.panel1.Controls.Add(this.LblCardNumber);
            this.panel1.Controls.Add(this.LblCardName);
            this.panel1.Controls.Add(this.LblDateAA);
            this.panel1.Controls.Add(this.PicVisa_Logo);
            this.panel1.Controls.Add(this.PicMaster_Logo);
            this.panel1.Location = new System.Drawing.Point(418, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 215);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(65, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "/";
            // 
            // LblDateYY
            // 
            this.LblDateYY.AutoSize = true;
            this.LblDateYY.BackColor = System.Drawing.Color.Transparent;
            this.LblDateYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDateYY.ForeColor = System.Drawing.Color.Black;
            this.LblDateYY.Location = new System.Drawing.Point(74, 169);
            this.LblDateYY.Name = "LblDateYY";
            this.LblDateYY.Size = new System.Drawing.Size(26, 17);
            this.LblDateYY.TabIndex = 14;
            this.LblDateYY.Text = "YY";
            // 
            // LblCardNumber
            // 
            this.LblCardNumber.AutoSize = true;
            this.LblCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCardNumber.ForeColor = System.Drawing.Color.Black;
            this.LblCardNumber.Location = new System.Drawing.Point(41, 113);
            this.LblCardNumber.Name = "LblCardNumber";
            this.LblCardNumber.Size = new System.Drawing.Size(185, 22);
            this.LblCardNumber.TabIndex = 6;
            this.LblCardNumber.Text = "0000 0000 0000 0000";
            // 
            // LblCardName
            // 
            this.LblCardName.AutoSize = true;
            this.LblCardName.BackColor = System.Drawing.Color.Transparent;
            this.LblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCardName.ForeColor = System.Drawing.Color.Black;
            this.LblCardName.Location = new System.Drawing.Point(42, 146);
            this.LblCardName.Name = "LblCardName";
            this.LblCardName.Size = new System.Drawing.Size(77, 17);
            this.LblCardName.TabIndex = 11;
            this.LblCardName.Text = "Kart Sahibi";
            // 
            // LblDateAA
            // 
            this.LblDateAA.AutoSize = true;
            this.LblDateAA.BackColor = System.Drawing.Color.Transparent;
            this.LblDateAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDateAA.ForeColor = System.Drawing.Color.Black;
            this.LblDateAA.Location = new System.Drawing.Point(42, 169);
            this.LblDateAA.Name = "LblDateAA";
            this.LblDateAA.Size = new System.Drawing.Size(26, 17);
            this.LblDateAA.TabIndex = 10;
            this.LblDateAA.Text = "AA";
            // 
            // PicVisa_Logo
            // 
            this.PicVisa_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PicVisa_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PicVisa_Logo.Image")));
            this.PicVisa_Logo.Location = new System.Drawing.Point(220, 159);
            this.PicVisa_Logo.Name = "PicVisa_Logo";
            this.PicVisa_Logo.Size = new System.Drawing.Size(78, 22);
            this.PicVisa_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVisa_Logo.TabIndex = 12;
            this.PicVisa_Logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(96, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Son kullanma tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(96, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kart sahibi";
            // 
            // TxtCardName
            // 
            this.TxtCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCardName.Location = new System.Drawing.Point(100, 113);
            this.TxtCardName.Name = "TxtCardName";
            this.TxtCardName.Size = new System.Drawing.Size(262, 27);
            this.TxtCardName.TabIndex = 23;
            this.TxtCardName.TextChanged += new System.EventHandler(this.TxtCardName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(96, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kart numarası";
            // 
            // TxtCardNumber
            // 
            this.TxtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCardNumber.Location = new System.Drawing.Point(100, 176);
            this.TxtCardNumber.MaxLength = 19;
            this.TxtCardNumber.Name = "TxtCardNumber";
            this.TxtCardNumber.Size = new System.Drawing.Size(262, 27);
            this.TxtCardNumber.TabIndex = 25;
            this.TxtCardNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCardNumber_KeyUp);
            // 
            // CboxCardType
            // 
            this.CboxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CboxCardType.FormattingEnabled = true;
            this.CboxCardType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard"});
            this.CboxCardType.Location = new System.Drawing.Point(100, 317);
            this.CboxCardType.Name = "CboxCardType";
            this.CboxCardType.Size = new System.Drawing.Size(122, 28);
            this.CboxCardType.TabIndex = 26;
            this.CboxCardType.SelectedIndexChanged += new System.EventHandler(this.CboxCardType_SelectedIndexChanged);
            // 
            // CustomerPaypentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(860, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboxYY);
            this.Controls.Add(this.CboxAA);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCardName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCardNumber);
            this.Controls.Add(this.CboxCardType);
            this.Name = "CustomerPaypentForm";
            this.Text = "CustomerPaypentForm";
            ((System.ComponentModel.ISupportInitialize)(this.PicMaster_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVisa_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxYY;
        private System.Windows.Forms.ComboBox CboxAA;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.PictureBox PicMaster_Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblDateYY;
        private System.Windows.Forms.Label LblCardNumber;
        private System.Windows.Forms.Label LblCardName;
        private System.Windows.Forms.Label LblDateAA;
        private System.Windows.Forms.PictureBox PicVisa_Logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCardName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCardNumber;
        private System.Windows.Forms.ComboBox CboxCardType;
    }
}