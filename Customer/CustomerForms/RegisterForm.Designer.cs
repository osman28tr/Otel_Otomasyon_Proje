namespace Otel_Rezervasyon.Customer.CustomerForms
{
    partial class RegisterForm
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.CalendarBirth = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.textName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textLastname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comboBoxGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.textPhoneNum = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Confirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGender)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEmail.Location = new System.Drawing.Point(173, 297);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(88, 29);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Eposta";
            // 
            // CalendarBirth
            // 
            this.CalendarBirth.Location = new System.Drawing.Point(310, 420);
            this.CalendarBirth.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.CalendarBirth.MaxSelectionCount = 1;
            this.CalendarBirth.Name = "CalendarBirth";
            this.CalendarBirth.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(163, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(110, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(180, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(219, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(178, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Parola";
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
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(285, 88);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(308, 34);
            this.textName.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.textName.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.textName.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.textName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textName.StateCommon.Border.Rounding = 20;
            this.textName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textName.TabIndex = 30;
            // 
            // textLastname
            // 
            this.textLastname.Location = new System.Drawing.Point(285, 137);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(308, 34);
            this.textLastname.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.textLastname.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.textLastname.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.textLastname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textLastname.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textLastname.StateCommon.Border.Rounding = 20;
            this.textLastname.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textLastname.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textLastname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textLastname.TabIndex = 31;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownWidth = 149;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxGender.Location = new System.Drawing.Point(285, 187);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(161, 37);
            this.comboBoxGender.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Bisque;
            this.comboBoxGender.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.DimGray;
            this.comboBoxGender.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.DimGray;
            this.comboBoxGender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxGender.StateCommon.ComboBox.Border.Rounding = 20;
            this.comboBoxGender.TabIndex = 32;
            this.comboBoxGender.TabStop = false;
            // 
            // textPhoneNum
            // 
            this.textPhoneNum.Location = new System.Drawing.Point(285, 243);
            this.textPhoneNum.Name = "textPhoneNum";
            this.textPhoneNum.Size = new System.Drawing.Size(308, 34);
            this.textPhoneNum.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.textPhoneNum.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.textPhoneNum.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.textPhoneNum.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textPhoneNum.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textPhoneNum.StateCommon.Border.Rounding = 20;
            this.textPhoneNum.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textPhoneNum.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPhoneNum.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textPhoneNum.TabIndex = 33;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(285, 297);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(308, 34);
            this.textEmail.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.textEmail.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.textEmail.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.textEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textEmail.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textEmail.StateCommon.Border.Rounding = 20;
            this.textEmail.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textEmail.TabIndex = 34;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(285, 358);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(308, 34);
            this.textPassword.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.textPassword.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.textPassword.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.textPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textPassword.StateCommon.Border.Rounding = 20;
            this.textPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textPassword.TabIndex = 35;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(310, 659);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.OverrideDefault.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Confirm.OverrideDefault.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Confirm.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Confirm.OverrideDefault.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Confirm.OverrideDefault.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Confirm.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Confirm.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Confirm.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Confirm.OverrideDefault.Border.Rounding = 20;
            this.btn_Confirm.OverrideDefault.Border.Width = 1;
            this.btn_Confirm.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Confirm.Size = new System.Drawing.Size(271, 56);
            this.btn_Confirm.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StateCommon.Back.ColorAngle = 45F;
            this.btn_Confirm.StateCommon.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Confirm.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Confirm.StateCommon.Border.Rounding = 20;
            this.btn_Confirm.StateCommon.Border.Width = 1;
            this.btn_Confirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Confirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Confirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Confirm.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StatePressed.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StatePressed.Back.ColorAngle = 135F;
            this.btn_Confirm.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StatePressed.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Confirm.StatePressed.Border.ColorAngle = 135F;
            this.btn_Confirm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Confirm.StatePressed.Border.Rounding = 20;
            this.btn_Confirm.StatePressed.Border.Width = 1;
            this.btn_Confirm.StateTracking.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Confirm.StateTracking.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Confirm.StateTracking.Back.ColorAngle = 45F;
            this.btn_Confirm.StateTracking.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Confirm.StateTracking.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Confirm.StateTracking.Border.ColorAngle = 45F;
            this.btn_Confirm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Confirm.StateTracking.Border.Rounding = 20;
            this.btn_Confirm.StateTracking.Border.Width = 1;
            this.btn_Confirm.TabIndex = 36;
            this.btn_Confirm.Values.Text = "Onayla";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(342, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "OPHELIA’S OASIS";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(855, 736);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhoneNum);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.CalendarBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.MonthCalendar CalendarBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textLastname;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxGender;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textPhoneNum;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confirm;
        private System.Windows.Forms.Label label7;
    }
}