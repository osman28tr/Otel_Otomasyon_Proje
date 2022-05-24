using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Otel_Rezervasyon.Hotel.ReservationForms
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.CalendarReservation = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_Confirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // CalendarReservation
            // 
            this.CalendarReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalendarReservation.Location = new System.Drawing.Point(227, 154);
            this.CalendarReservation.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.CalendarReservation.MaxSelectionCount = 100;
            this.CalendarReservation.Name = "CalendarReservation";
            this.CalendarReservation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CalendarReservation.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 4, 25, 0, 0, 0, 0), new System.DateTime(2022, 4, 30, 0, 0, 0, 0));
            this.CalendarReservation.ShowTodayCircle = false;
            this.CalendarReservation.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rezervasyon Tarihi";
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
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(227, 402);
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
            this.btn_Confirm.Size = new System.Drawing.Size(262, 56);
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
            this.btn_Confirm.TabIndex = 21;
            this.btn_Confirm.Values.Text = "Onayla";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(707, 545);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.CalendarReservation);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonthCalendar CalendarReservation;
        private Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confirm;
    }
}