namespace Otel_Rezervasyon.Reservation.ReservationForms
{
    partial class ReservationForm
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
            this.CalendarReservation = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalendarReservation
            // 
            this.CalendarReservation.Location = new System.Drawing.Point(180, 58);
            this.CalendarReservation.MaxSelectionCount = 100;
            this.CalendarReservation.Name = "CalendarReservation";
            this.CalendarReservation.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 4, 25, 0, 0, 0, 0), new System.DateTime(2022, 4, 30, 0, 0, 0, 0));
            this.CalendarReservation.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rezervasyon Tarihi";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Confirm.Location = new System.Drawing.Point(258, 295);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(125, 58);
            this.btn_Confirm.TabIndex = 14;
            this.btn_Confirm.Text = "Onayla";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 418);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.CalendarReservation);
            this.Controls.Add(this.label5);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarReservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Confirm;
    }
}