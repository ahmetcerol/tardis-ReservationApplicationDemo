
namespace YazılımMimarisiProje.UI.Forms
{
    partial class AboutReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutReservation));
            this.pnlAboutReservation = new System.Windows.Forms.Panel();
            this.lblPaymentInformation = new System.Windows.Forms.Label();
            this.btnApproval = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceInformation = new System.Windows.Forms.Label();
            this.pbxReservation = new System.Windows.Forms.PictureBox();
            this.tbxQuitDate = new System.Windows.Forms.TextBox();
            this.tbxEnterDate = new System.Windows.Forms.TextBox();
            this.tbxAccomodation = new System.Windows.Forms.TextBox();
            this.tbxTransportation = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTranportation = new System.Windows.Forms.Label();
            this.lblAccomadition = new System.Windows.Forms.Label();
            this.lblQuitDateTime = new System.Windows.Forms.Label();
            this.lblEnterDateTime = new System.Windows.Forms.Label();
            this.pnlAboutReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAboutReservation
            // 
            this.pnlAboutReservation.Controls.Add(this.lblPaymentInformation);
            this.pnlAboutReservation.Controls.Add(this.btnApproval);
            this.pnlAboutReservation.Controls.Add(this.lblConfirmation);
            this.pnlAboutReservation.Controls.Add(this.lblPrice);
            this.pnlAboutReservation.Controls.Add(this.lblPriceInformation);
            this.pnlAboutReservation.Controls.Add(this.pbxReservation);
            this.pnlAboutReservation.Controls.Add(this.tbxQuitDate);
            this.pnlAboutReservation.Controls.Add(this.tbxEnterDate);
            this.pnlAboutReservation.Controls.Add(this.tbxAccomodation);
            this.pnlAboutReservation.Controls.Add(this.tbxTransportation);
            this.pnlAboutReservation.Controls.Add(this.tbxEmail);
            this.pnlAboutReservation.Controls.Add(this.lblEmail);
            this.pnlAboutReservation.Controls.Add(this.lblTranportation);
            this.pnlAboutReservation.Controls.Add(this.lblAccomadition);
            this.pnlAboutReservation.Controls.Add(this.lblQuitDateTime);
            this.pnlAboutReservation.Controls.Add(this.lblEnterDateTime);
            this.pnlAboutReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAboutReservation.Location = new System.Drawing.Point(0, 0);
            this.pnlAboutReservation.Name = "pnlAboutReservation";
            this.pnlAboutReservation.Size = new System.Drawing.Size(633, 397);
            this.pnlAboutReservation.TabIndex = 0;
            // 
            // lblPaymentInformation
            // 
            this.lblPaymentInformation.AutoSize = true;
            this.lblPaymentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentInformation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPaymentInformation.Location = new System.Drawing.Point(178, 341);
            this.lblPaymentInformation.Name = "lblPaymentInformation";
            this.lblPaymentInformation.Size = new System.Drawing.Size(280, 30);
            this.lblPaymentInformation.TabIndex = 49;
            this.lblPaymentInformation.Text = "**Ücret tesisimize vardığınızda tahsis edilecektir.**\r\n\r\n";
            // 
            // btnApproval
            // 
            this.btnApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnApproval.FlatAppearance.BorderSize = 0;
            this.btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApproval.ForeColor = System.Drawing.Color.White;
            this.btnApproval.Image = ((System.Drawing.Image)(resources.GetObject("btnApproval.Image")));
            this.btnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.Location = new System.Drawing.Point(504, 341);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(110, 39);
            this.btnApproval.TabIndex = 48;
            this.btnApproval.Text = "   Onayla";
            this.btnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApproval.UseVisualStyleBackColor = false;
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmation.Location = new System.Drawing.Point(337, 226);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(121, 15);
            this.lblConfirmation.TabIndex = 47;
            this.lblConfirmation.Text = "Onaylıyor Musunuz ?\r\n";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(284, 226);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 15);
            this.lblPrice.TabIndex = 46;
            this.lblPrice.Text = "---";
            // 
            // lblPriceInformation
            // 
            this.lblPriceInformation.AutoSize = true;
            this.lblPriceInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceInformation.Location = new System.Drawing.Point(18, 226);
            this.lblPriceInformation.Name = "lblPriceInformation";
            this.lblPriceInformation.Size = new System.Drawing.Size(260, 15);
            this.lblPriceInformation.TabIndex = 45;
            this.lblPriceInformation.Text = "Bilgili rezervasyonunuza ait ücret şu şekildedir:\r\n";
            // 
            // pbxReservation
            // 
            this.pbxReservation.Image = ((System.Drawing.Image)(resources.GetObject("pbxReservation.Image")));
            this.pbxReservation.Location = new System.Drawing.Point(459, 16);
            this.pbxReservation.Name = "pbxReservation";
            this.pbxReservation.Size = new System.Drawing.Size(121, 80);
            this.pbxReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReservation.TabIndex = 44;
            this.pbxReservation.TabStop = false;
            // 
            // tbxQuitDate
            // 
            this.tbxQuitDate.Enabled = false;
            this.tbxQuitDate.Location = new System.Drawing.Point(202, 62);
            this.tbxQuitDate.Name = "tbxQuitDate";
            this.tbxQuitDate.Size = new System.Drawing.Size(112, 20);
            this.tbxQuitDate.TabIndex = 43;
            // 
            // tbxEnterDate
            // 
            this.tbxEnterDate.Enabled = false;
            this.tbxEnterDate.Location = new System.Drawing.Point(202, 35);
            this.tbxEnterDate.Name = "tbxEnterDate";
            this.tbxEnterDate.Size = new System.Drawing.Size(112, 20);
            this.tbxEnterDate.TabIndex = 42;
            // 
            // tbxAccomodation
            // 
            this.tbxAccomodation.Enabled = false;
            this.tbxAccomodation.Location = new System.Drawing.Point(123, 107);
            this.tbxAccomodation.Name = "tbxAccomodation";
            this.tbxAccomodation.Size = new System.Drawing.Size(112, 20);
            this.tbxAccomodation.TabIndex = 41;
            // 
            // tbxTransportation
            // 
            this.tbxTransportation.Enabled = false;
            this.tbxTransportation.Location = new System.Drawing.Point(123, 136);
            this.tbxTransportation.Name = "tbxTransportation";
            this.tbxTransportation.Size = new System.Drawing.Size(112, 20);
            this.tbxTransportation.TabIndex = 40;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(123, 162);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(112, 20);
            this.tbxEmail.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(18, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // lblTranportation
            // 
            this.lblTranportation.AutoSize = true;
            this.lblTranportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTranportation.Location = new System.Drawing.Point(18, 137);
            this.lblTranportation.Name = "lblTranportation";
            this.lblTranportation.Size = new System.Drawing.Size(56, 15);
            this.lblTranportation.TabIndex = 37;
            this.lblTranportation.Text = "Ulaşım:";
            // 
            // lblAccomadition
            // 
            this.lblAccomadition.AutoSize = true;
            this.lblAccomadition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccomadition.Location = new System.Drawing.Point(18, 112);
            this.lblAccomadition.Name = "lblAccomadition";
            this.lblAccomadition.Size = new System.Drawing.Size(83, 15);
            this.lblAccomadition.TabIndex = 36;
            this.lblAccomadition.Text = "Konaklama:";
            // 
            // lblQuitDateTime
            // 
            this.lblQuitDateTime.AutoSize = true;
            this.lblQuitDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuitDateTime.Location = new System.Drawing.Point(18, 63);
            this.lblQuitDateTime.Name = "lblQuitDateTime";
            this.lblQuitDateTime.Size = new System.Drawing.Size(161, 15);
            this.lblQuitDateTime.TabIndex = 35;
            this.lblQuitDateTime.Text = "Çıkış Yapacağınız Tarih:";
            // 
            // lblEnterDateTime
            // 
            this.lblEnterDateTime.AutoSize = true;
            this.lblEnterDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnterDateTime.Location = new System.Drawing.Point(18, 35);
            this.lblEnterDateTime.Name = "lblEnterDateTime";
            this.lblEnterDateTime.Size = new System.Drawing.Size(160, 15);
            this.lblEnterDateTime.TabIndex = 34;
            this.lblEnterDateTime.Text = "Giriş Yapacağınız Tarih:";
            // 
            // AboutReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 397);
            this.Controls.Add(this.pnlAboutReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutReservation";
            this.Text = "ReservationInformation";
            this.Load += new System.EventHandler(this.AboutReservation_Load);
            this.pnlAboutReservation.ResumeLayout(false);
            this.pnlAboutReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAboutReservation;
        private System.Windows.Forms.Label lblPaymentInformation;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceInformation;
        private System.Windows.Forms.PictureBox pbxReservation;
        private System.Windows.Forms.TextBox tbxQuitDate;
        private System.Windows.Forms.TextBox tbxEnterDate;
        private System.Windows.Forms.TextBox tbxAccomodation;
        private System.Windows.Forms.TextBox tbxTransportation;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTranportation;
        private System.Windows.Forms.Label lblAccomadition;
        private System.Windows.Forms.Label lblQuitDateTime;
        private System.Windows.Forms.Label lblEnterDateTime;
    }
}