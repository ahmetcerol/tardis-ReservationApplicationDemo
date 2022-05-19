
namespace YazılımMimarisiProje.UI.Forms
{
    partial class ReservationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationControl));
            this.pnlRezervationControl = new System.Windows.Forms.Panel();
            this.btnGetADocument = new System.Windows.Forms.Button();
            this.lblReservationInformation = new System.Windows.Forms.Label();
            this.pbxReservation = new System.Windows.Forms.PictureBox();
            this.tbxPersonalIdentificationNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlRezervationControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRezervationControl
            // 
            this.pnlRezervationControl.Controls.Add(this.btnGetADocument);
            this.pnlRezervationControl.Controls.Add(this.lblReservationInformation);
            this.pnlRezervationControl.Controls.Add(this.pbxReservation);
            this.pnlRezervationControl.Controls.Add(this.tbxPersonalIdentificationNo);
            this.pnlRezervationControl.Controls.Add(this.label2);
            this.pnlRezervationControl.Controls.Add(this.tbxEmail);
            this.pnlRezervationControl.Controls.Add(this.lblEmail);
            this.pnlRezervationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRezervationControl.Location = new System.Drawing.Point(0, 0);
            this.pnlRezervationControl.Name = "pnlRezervationControl";
            this.pnlRezervationControl.Size = new System.Drawing.Size(633, 397);
            this.pnlRezervationControl.TabIndex = 0;
            // 
            // btnGetADocument
            // 
            this.btnGetADocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnGetADocument.FlatAppearance.BorderSize = 0;
            this.btnGetADocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetADocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetADocument.ForeColor = System.Drawing.Color.White;
            this.btnGetADocument.Image = ((System.Drawing.Image)(resources.GetObject("btnGetADocument.Image")));
            this.btnGetADocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetADocument.Location = new System.Drawing.Point(447, 338);
            this.btnGetADocument.Name = "btnGetADocument";
            this.btnGetADocument.Size = new System.Drawing.Size(162, 44);
            this.btnGetADocument.TabIndex = 44;
            this.btnGetADocument.Text = "Rapor Oluştur";
            this.btnGetADocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetADocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetADocument.UseVisualStyleBackColor = false;
            this.btnGetADocument.Click += new System.EventHandler(this.btnGetADocument_Click);
            // 
            // lblReservationInformation
            // 
            this.lblReservationInformation.AutoSize = true;
            this.lblReservationInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReservationInformation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReservationInformation.Location = new System.Drawing.Point(24, 337);
            this.lblReservationInformation.Name = "lblReservationInformation";
            this.lblReservationInformation.Size = new System.Drawing.Size(278, 45);
            this.lblReservationInformation.TabIndex = 43;
            this.lblReservationInformation.Text = "**Rezervasyonunuza ait raporu oluşturabilirsiniz**\r\n\r\n\r\n";
            // 
            // pbxReservation
            // 
            this.pbxReservation.Image = ((System.Drawing.Image)(resources.GetObject("pbxReservation.Image")));
            this.pbxReservation.Location = new System.Drawing.Point(480, 14);
            this.pbxReservation.Name = "pbxReservation";
            this.pbxReservation.Size = new System.Drawing.Size(98, 76);
            this.pbxReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReservation.TabIndex = 42;
            this.pbxReservation.TabStop = false;
            // 
            // tbxPersonalIdentificationNo
            // 
            this.tbxPersonalIdentificationNo.Location = new System.Drawing.Point(149, 70);
            this.tbxPersonalIdentificationNo.Name = "tbxPersonalIdentificationNo";
            this.tbxPersonalIdentificationNo.Size = new System.Drawing.Size(112, 20);
            this.tbxPersonalIdentificationNo.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tc. Kimlik No:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(149, 96);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(112, 20);
            this.tbxEmail.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(91, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // ReservationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 397);
            this.Controls.Add(this.pnlRezervationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationControl";
            this.Text = "ReservationControl";
            this.pnlRezervationControl.ResumeLayout(false);
            this.pnlRezervationControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRezervationControl;
        private System.Windows.Forms.Button btnGetADocument;
        private System.Windows.Forms.Label lblReservationInformation;
        private System.Windows.Forms.PictureBox pbxReservation;
        private System.Windows.Forms.TextBox tbxPersonalIdentificationNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}