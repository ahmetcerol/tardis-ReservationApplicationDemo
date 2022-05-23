
namespace YazılımMimarisiProje.UI.Forms
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.pnlGetingReservation = new System.Windows.Forms.Panel();
            this.lblReservationInfo = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.pbxReservation = new System.Windows.Forms.PictureBox();
            this.dtpQuit = new System.Windows.Forms.DateTimePicker();
            this.lblQuitDateTime = new System.Windows.Forms.Label();
            this.dtpEnter = new System.Windows.Forms.DateTimePicker();
            this.lblEnterDateTime = new System.Windows.Forms.Label();
            this.cbxTransportation = new System.Windows.Forms.ComboBox();
            this.lblTranportation = new System.Windows.Forms.Label();
            this.cbxAccomodation = new System.Windows.Forms.ComboBox();
            this.lblAccomadition = new System.Windows.Forms.Label();
            this.pnlGetingReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGetingReservation
            // 
            this.pnlGetingReservation.Controls.Add(this.lblReservationInfo);
            this.pnlGetingReservation.Controls.Add(this.btnForward);
            this.pnlGetingReservation.Controls.Add(this.pbxReservation);
            this.pnlGetingReservation.Controls.Add(this.dtpQuit);
            this.pnlGetingReservation.Controls.Add(this.lblQuitDateTime);
            this.pnlGetingReservation.Controls.Add(this.dtpEnter);
            this.pnlGetingReservation.Controls.Add(this.lblEnterDateTime);
            this.pnlGetingReservation.Controls.Add(this.cbxTransportation);
            this.pnlGetingReservation.Controls.Add(this.lblTranportation);
            this.pnlGetingReservation.Controls.Add(this.cbxAccomodation);
            this.pnlGetingReservation.Controls.Add(this.lblAccomadition);
            this.pnlGetingReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGetingReservation.Location = new System.Drawing.Point(0, 0);
            this.pnlGetingReservation.Name = "pnlGetingReservation";
            this.pnlGetingReservation.Size = new System.Drawing.Size(633, 397);
            this.pnlGetingReservation.TabIndex = 0;
            // 
            // lblReservationInfo
            // 
            this.lblReservationInfo.AutoSize = true;
            this.lblReservationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReservationInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReservationInfo.Location = new System.Drawing.Point(57, 325);
            this.lblReservationInfo.Name = "lblReservationInfo";
            this.lblReservationInfo.Size = new System.Drawing.Size(376, 60);
            this.lblReservationInfo.TabIndex = 50;
            this.lblReservationInfo.Text = resources.GetString("lblReservationInfo.Text");
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForward.Location = new System.Drawing.Point(511, 351);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(110, 34);
            this.btnForward.TabIndex = 19;
            this.btnForward.Text = "   İlerle";
            this.btnForward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // pbxReservation
            // 
            this.pbxReservation.Image = ((System.Drawing.Image)(resources.GetObject("pbxReservation.Image")));
            this.pbxReservation.Location = new System.Drawing.Point(455, 35);
            this.pbxReservation.Name = "pbxReservation";
            this.pbxReservation.Size = new System.Drawing.Size(121, 80);
            this.pbxReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReservation.TabIndex = 18;
            this.pbxReservation.TabStop = false;
            // 
            // dtpQuit
            // 
            this.dtpQuit.Location = new System.Drawing.Point(223, 252);
            this.dtpQuit.MaxDate = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            this.dtpQuit.MinDate = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            this.dtpQuit.Name = "dtpQuit";
            this.dtpQuit.Size = new System.Drawing.Size(200, 20);
            this.dtpQuit.TabIndex = 17;
            this.dtpQuit.Value = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            // 
            // lblQuitDateTime
            // 
            this.lblQuitDateTime.AutoSize = true;
            this.lblQuitDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuitDateTime.Location = new System.Drawing.Point(58, 256);
            this.lblQuitDateTime.Name = "lblQuitDateTime";
            this.lblQuitDateTime.Size = new System.Drawing.Size(161, 15);
            this.lblQuitDateTime.TabIndex = 16;
            this.lblQuitDateTime.Text = "Çıkış Yapacağınız Tarih:";
            // 
            // dtpEnter
            // 
            this.dtpEnter.Location = new System.Drawing.Point(223, 219);
            this.dtpEnter.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpEnter.MinDate = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            this.dtpEnter.Name = "dtpEnter";
            this.dtpEnter.Size = new System.Drawing.Size(200, 20);
            this.dtpEnter.TabIndex = 15;
            this.dtpEnter.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // lblEnterDateTime
            // 
            this.lblEnterDateTime.AutoSize = true;
            this.lblEnterDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnterDateTime.Location = new System.Drawing.Point(57, 219);
            this.lblEnterDateTime.Name = "lblEnterDateTime";
            this.lblEnterDateTime.Size = new System.Drawing.Size(160, 15);
            this.lblEnterDateTime.TabIndex = 14;
            this.lblEnterDateTime.Text = "Giriş Yapacağınız Tarih:";
            // 
            // cbxTransportation
            // 
            this.cbxTransportation.FormattingEnabled = true;
            this.cbxTransportation.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.cbxTransportation.Location = new System.Drawing.Point(148, 108);
            this.cbxTransportation.Name = "cbxTransportation";
            this.cbxTransportation.Size = new System.Drawing.Size(124, 21);
            this.cbxTransportation.TabIndex = 13;
            // 
            // lblTranportation
            // 
            this.lblTranportation.AutoSize = true;
            this.lblTranportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTranportation.Location = new System.Drawing.Point(61, 109);
            this.lblTranportation.Name = "lblTranportation";
            this.lblTranportation.Size = new System.Drawing.Size(56, 15);
            this.lblTranportation.TabIndex = 12;
            this.lblTranportation.Text = "Ulaşım:";
            // 
            // cbxAccomodation
            // 
            this.cbxAccomodation.FormattingEnabled = true;
            this.cbxAccomodation.Items.AddRange(new object[] {
            "Çadır",
            "Otel"});
            this.cbxAccomodation.Location = new System.Drawing.Point(148, 66);
            this.cbxAccomodation.Name = "cbxAccomodation";
            this.cbxAccomodation.Size = new System.Drawing.Size(124, 21);
            this.cbxAccomodation.TabIndex = 11;
            // 
            // lblAccomadition
            // 
            this.lblAccomadition.AutoSize = true;
            this.lblAccomadition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccomadition.Location = new System.Drawing.Point(62, 67);
            this.lblAccomadition.Name = "lblAccomadition";
            this.lblAccomadition.Size = new System.Drawing.Size(83, 15);
            this.lblAccomadition.TabIndex = 10;
            this.lblAccomadition.Text = "Konaklama:";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 397);
            this.Controls.Add(this.pnlGetingReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.pnlGetingReservation.ResumeLayout(false);
            this.pnlGetingReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGetingReservation;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.PictureBox pbxReservation;
        private System.Windows.Forms.DateTimePicker dtpQuit;
        private System.Windows.Forms.Label lblQuitDateTime;
        private System.Windows.Forms.DateTimePicker dtpEnter;
        private System.Windows.Forms.Label lblEnterDateTime;
        private System.Windows.Forms.ComboBox cbxTransportation;
        private System.Windows.Forms.Label lblTranportation;
        private System.Windows.Forms.ComboBox cbxAccomodation;
        private System.Windows.Forms.Label lblAccomadition;
        private System.Windows.Forms.Label lblReservationInfo;
    }
}