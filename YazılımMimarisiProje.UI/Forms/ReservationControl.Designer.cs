
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPersonalIdentificationNo = new System.Windows.Forms.TextBox();
            this.pbxReservation = new System.Windows.Forms.PictureBox();
            this.lblReservationInformation = new System.Windows.Forms.Label();
            this.btnGetADocument = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(103, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(161, 99);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(112, 20);
            this.tbxEmail.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tc. Kimlik No:";
            // 
            // tbxPersonalIdentificationNo
            // 
            this.tbxPersonalIdentificationNo.Location = new System.Drawing.Point(161, 73);
            this.tbxPersonalIdentificationNo.Name = "tbxPersonalIdentificationNo";
            this.tbxPersonalIdentificationNo.Size = new System.Drawing.Size(112, 20);
            this.tbxPersonalIdentificationNo.TabIndex = 34;
            // 
            // pbxReservation
            // 
            this.pbxReservation.Image = ((System.Drawing.Image)(resources.GetObject("pbxReservation.Image")));
            this.pbxReservation.Location = new System.Drawing.Point(492, 17);
            this.pbxReservation.Name = "pbxReservation";
            this.pbxReservation.Size = new System.Drawing.Size(98, 76);
            this.pbxReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReservation.TabIndex = 35;
            this.pbxReservation.TabStop = false;
            // 
            // lblReservationInformation
            // 
            this.lblReservationInformation.AutoSize = true;
            this.lblReservationInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReservationInformation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReservationInformation.Location = new System.Drawing.Point(36, 340);
            this.lblReservationInformation.Name = "lblReservationInformation";
            this.lblReservationInformation.Size = new System.Drawing.Size(278, 45);
            this.lblReservationInformation.TabIndex = 36;
            this.lblReservationInformation.Text = "**Rezervasyonunuza ait raporu oluşturabilirsiniz**\r\n\r\n\r\n";
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
            this.btnGetADocument.Location = new System.Drawing.Point(459, 341);
            this.btnGetADocument.Name = "btnGetADocument";
            this.btnGetADocument.Size = new System.Drawing.Size(162, 44);
            this.btnGetADocument.TabIndex = 37;
            this.btnGetADocument.Text = "Rapor Oluştur";
            this.btnGetADocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetADocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetADocument.UseVisualStyleBackColor = false;
            // 
            // ReservationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 397);
            this.Controls.Add(this.btnGetADocument);
            this.Controls.Add(this.lblReservationInformation);
            this.Controls.Add(this.pbxReservation);
            this.Controls.Add(this.tbxPersonalIdentificationNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationControl";
            this.Text = "ReservationControl";
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPersonalIdentificationNo;
        private System.Windows.Forms.PictureBox pbxReservation;
        private System.Windows.Forms.Label lblReservationInformation;
        private System.Windows.Forms.Button btnGetADocument;
    }
}