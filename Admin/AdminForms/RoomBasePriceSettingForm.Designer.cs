namespace Otel_Rezervasyon.Admin.AdminForms
{
    partial class RoomBasePriceSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.textBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Update = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlangıç Bitiş Tarihi";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 34);
            this.textBox1.StateCommon.Back.Color1 = System.Drawing.Color.Bisque;
            this.textBox1.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.textBox1.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.textBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox1.StateCommon.Border.Rounding = 20;
            this.textBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox1.TabIndex = 13;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(72, 638);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OverrideDefault.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Add.OverrideDefault.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Add.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Add.OverrideDefault.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Add.OverrideDefault.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Add.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Add.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Add.OverrideDefault.Border.Rounding = 20;
            this.btn_Add.OverrideDefault.Border.Width = 1;
            this.btn_Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Add.Size = new System.Drawing.Size(197, 56);
            this.btn_Add.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Add.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Add.StateCommon.Back.ColorAngle = 45F;
            this.btn_Add.StateCommon.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Add.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Add.StateCommon.Border.Rounding = 20;
            this.btn_Add.StateCommon.Border.Width = 1;
            this.btn_Add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Add.StatePressed.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Add.StatePressed.Back.ColorAngle = 135F;
            this.btn_Add.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Add.StatePressed.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Add.StatePressed.Border.ColorAngle = 135F;
            this.btn_Add.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StatePressed.Border.Rounding = 20;
            this.btn_Add.StatePressed.Border.Width = 1;
            this.btn_Add.StateTracking.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Add.StateTracking.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Add.StateTracking.Back.ColorAngle = 45F;
            this.btn_Add.StateTracking.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Add.StateTracking.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Add.StateTracking.Border.ColorAngle = 45F;
            this.btn_Add.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StateTracking.Border.Rounding = 20;
            this.btn_Add.StateTracking.Border.Width = 1;
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Values.Text = "Ekle";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(349, 638);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.OverrideDefault.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Update.OverrideDefault.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Update.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Update.OverrideDefault.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Update.OverrideDefault.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Update.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Update.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Update.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Update.OverrideDefault.Border.Rounding = 20;
            this.btn_Update.OverrideDefault.Border.Width = 1;
            this.btn_Update.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Update.Size = new System.Drawing.Size(197, 56);
            this.btn_Update.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Update.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Update.StateCommon.Back.ColorAngle = 45F;
            this.btn_Update.StateCommon.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Update.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Update.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Update.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Update.StateCommon.Border.Rounding = 20;
            this.btn_Update.StateCommon.Border.Width = 1;
            this.btn_Update.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Update.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Update.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Update.StatePressed.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Update.StatePressed.Back.ColorAngle = 135F;
            this.btn_Update.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Update.StatePressed.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Update.StatePressed.Border.ColorAngle = 135F;
            this.btn_Update.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Update.StatePressed.Border.Rounding = 20;
            this.btn_Update.StatePressed.Border.Width = 1;
            this.btn_Update.StateTracking.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Update.StateTracking.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Update.StateTracking.Back.ColorAngle = 45F;
            this.btn_Update.StateTracking.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Update.StateTracking.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Update.StateTracking.Border.ColorAngle = 45F;
            this.btn_Update.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Update.StateTracking.Border.Rounding = 20;
            this.btn_Update.StateTracking.Border.Width = 1;
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Values.Text = "Güncelle";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(628, 638);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OverrideDefault.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Delete.OverrideDefault.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Delete.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Delete.OverrideDefault.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Delete.OverrideDefault.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Delete.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Delete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Delete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Delete.OverrideDefault.Border.Rounding = 20;
            this.btn_Delete.OverrideDefault.Border.Width = 1;
            this.btn_Delete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Delete.Size = new System.Drawing.Size(197, 56);
            this.btn_Delete.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StateCommon.Back.ColorAngle = 45F;
            this.btn_Delete.StateCommon.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Delete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Delete.StateCommon.Border.Rounding = 20;
            this.btn_Delete.StateCommon.Border.Width = 1;
            this.btn_Delete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Delete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StatePressed.Back.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StatePressed.Back.ColorAngle = 135F;
            this.btn_Delete.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StatePressed.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Delete.StatePressed.Border.ColorAngle = 135F;
            this.btn_Delete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Delete.StatePressed.Border.Rounding = 20;
            this.btn_Delete.StatePressed.Border.Width = 1;
            this.btn_Delete.StateTracking.Back.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Delete.StateTracking.Back.Color2 = System.Drawing.Color.Salmon;
            this.btn_Delete.StateTracking.Back.ColorAngle = 45F;
            this.btn_Delete.StateTracking.Border.Color1 = System.Drawing.Color.LightCoral;
            this.btn_Delete.StateTracking.Border.Color2 = System.Drawing.Color.Salmon;
            this.btn_Delete.StateTracking.Border.ColorAngle = 45F;
            this.btn_Delete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Delete.StateTracking.Border.Rounding = 20;
            this.btn_Delete.StateTracking.Border.Width = 1;
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Values.Text = "Sil";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(349, 410);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // RoomBasePriceSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(877, 732);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomBasePriceSettingForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomBasePriceSettingForm";
            this.Load += new System.EventHandler(this.RoomBasePriceSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Update;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Delete;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}