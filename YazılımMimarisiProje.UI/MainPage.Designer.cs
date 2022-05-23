
namespace YazılımMimarisiProje.UI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.ımgListOfMainPage = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlMainPageMenu = new System.Windows.Forms.Panel();
            this.btnReservationCancel = new System.Windows.Forms.Button();
            this.btnReservationControl = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.pnlMainPageLogo = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.pbxTent = new System.Windows.Forms.PictureBox();
            this.lblAboutTardis = new System.Windows.Forms.Label();
            this.pbxMainChildForm = new System.Windows.Forms.PictureBox();
            this.pbxHotel = new System.Windows.Forms.PictureBox();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.pnlMainPageMenu.SuspendLayout();
            this.pnlMainPageLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlChildForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // ımgListOfMainPage
            // 
            this.ımgListOfMainPage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımgListOfMainPage.ImageStream")));
            this.ımgListOfMainPage.TransparentColor = System.Drawing.Color.White;
            this.ımgListOfMainPage.Images.SetKeyName(0, "close (3).png");
            this.ımgListOfMainPage.Images.SetKeyName(1, "minimize (2).png");
            this.ımgListOfMainPage.Images.SetKeyName(2, "maximize-size-option (2).png");
            this.ımgListOfMainPage.Images.SetKeyName(3, "reservation.png");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(765, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(736, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 23);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(707, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMainPageMenu
            // 
            this.pnlMainPageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.pnlMainPageMenu.Controls.Add(this.btnReservationCancel);
            this.pnlMainPageMenu.Controls.Add(this.btnReservationControl);
            this.pnlMainPageMenu.Controls.Add(this.btnReservation);
            this.pnlMainPageMenu.Controls.Add(this.pnlMainPageLogo);
            this.pnlMainPageMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainPageMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPageMenu.Name = "pnlMainPageMenu";
            this.pnlMainPageMenu.Size = new System.Drawing.Size(149, 450);
            this.pnlMainPageMenu.TabIndex = 3;
            // 
            // btnReservationCancel
            // 
            this.btnReservationCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationCancel.FlatAppearance.BorderSize = 0;
            this.btnReservationCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservationCancel.ForeColor = System.Drawing.Color.White;
            this.btnReservationCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationCancel.Image")));
            this.btnReservationCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationCancel.Location = new System.Drawing.Point(0, 192);
            this.btnReservationCancel.Name = "btnReservationCancel";
            this.btnReservationCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReservationCancel.Size = new System.Drawing.Size(149, 46);
            this.btnReservationCancel.TabIndex = 3;
            this.btnReservationCancel.Text = "Rezervasyon Silme";
            this.btnReservationCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReservationCancel.UseVisualStyleBackColor = true;
            this.btnReservationCancel.Click += new System.EventHandler(this.btnReservationCancel_Click);
            // 
            // btnReservationControl
            // 
            this.btnReservationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationControl.FlatAppearance.BorderSize = 0;
            this.btnReservationControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservationControl.ForeColor = System.Drawing.Color.White;
            this.btnReservationControl.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationControl.Image")));
            this.btnReservationControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationControl.Location = new System.Drawing.Point(0, 146);
            this.btnReservationControl.Name = "btnReservationControl";
            this.btnReservationControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReservationControl.Size = new System.Drawing.Size(149, 46);
            this.btnReservationControl.TabIndex = 2;
            this.btnReservationControl.Text = "Reservasyon Kontrol";
            this.btnReservationControl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReservationControl.UseVisualStyleBackColor = true;
            this.btnReservationControl.Click += new System.EventHandler(this.btnReservationControl_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(0, 100);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReservation.Size = new System.Drawing.Size(149, 46);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservasyon";
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // pnlMainPageLogo
            // 
            this.pnlMainPageLogo.Controls.Add(this.pbxLogo);
            this.pnlMainPageLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainPageLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPageLogo.Name = "pnlMainPageLogo";
            this.pnlMainPageLogo.Size = new System.Drawing.Size(149, 100);
            this.pnlMainPageLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(149, 100);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.UseWaitCursor = true;
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChildForms.Controls.Add(this.pbxTent);
            this.pnlChildForms.Controls.Add(this.lblAboutTardis);
            this.pnlChildForms.Controls.Add(this.pbxMainChildForm);
            this.pnlChildForms.Controls.Add(this.pbxHotel);
            this.pnlChildForms.Location = new System.Drawing.Point(155, 41);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(633, 397);
            this.pnlChildForms.TabIndex = 4;
            this.pnlChildForms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlChildForms_MouseDown);
            // 
            // pbxTent
            // 
            this.pbxTent.Image = ((System.Drawing.Image)(resources.GetObject("pbxTent.Image")));
            this.pbxTent.Location = new System.Drawing.Point(354, 156);
            this.pbxTent.Name = "pbxTent";
            this.pbxTent.Size = new System.Drawing.Size(244, 217);
            this.pbxTent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTent.TabIndex = 7;
            this.pbxTent.TabStop = false;
            // 
            // lblAboutTardis
            // 
            this.lblAboutTardis.AutoSize = true;
            this.lblAboutTardis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboutTardis.Location = new System.Drawing.Point(157, 24);
            this.lblAboutTardis.Name = "lblAboutTardis";
            this.lblAboutTardis.Size = new System.Drawing.Size(361, 45);
            this.lblAboutTardis.TabIndex = 5;
            this.lblAboutTardis.Text = "Otel veya Çadır gibi tatil planlarınıza en kolay çözüm. Bize ait olan\r\nuçak veya " +
    "otobüs seçenekleriyle ulaşım sağlama rahatlığı.\r\nNe duruyorsun rezervasyonunu ya" +
    "psana.. .";
            // 
            // pbxMainChildForm
            // 
            this.pbxMainChildForm.Image = ((System.Drawing.Image)(resources.GetObject("pbxMainChildForm.Image")));
            this.pbxMainChildForm.Location = new System.Drawing.Point(34, 24);
            this.pbxMainChildForm.Name = "pbxMainChildForm";
            this.pbxMainChildForm.Size = new System.Drawing.Size(101, 98);
            this.pbxMainChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMainChildForm.TabIndex = 4;
            this.pbxMainChildForm.TabStop = false;
            // 
            // pbxHotel
            // 
            this.pbxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pbxHotel.Image")));
            this.pbxHotel.Location = new System.Drawing.Point(72, 156);
            this.pbxHotel.Name = "pbxHotel";
            this.pbxHotel.Size = new System.Drawing.Size(239, 217);
            this.pbxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHotel.TabIndex = 6;
            this.pbxHotel.TabStop = false;
            // 
            // btnBackMain
            // 
            this.btnBackMain.BackColor = System.Drawing.Color.White;
            this.btnBackMain.FlatAppearance.BorderSize = 0;
            this.btnBackMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMain.Image")));
            this.btnBackMain.Location = new System.Drawing.Point(155, 6);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(35, 34);
            this.btnBackMain.TabIndex = 5;
            this.btnBackMain.UseVisualStyleBackColor = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackMain);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.pnlMainPageMenu);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.pnlMainPageMenu.ResumeLayout(false);
            this.pnlMainPageLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlChildForms.ResumeLayout(false);
            this.pnlChildForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımgListOfMainPage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMainPageMenu;
        private System.Windows.Forms.Panel pnlMainPageLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnReservationCancel;
        private System.Windows.Forms.Button btnReservationControl;
        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.PictureBox pbxTent;
        private System.Windows.Forms.PictureBox pbxHotel;
        private System.Windows.Forms.Label lblAboutTardis;
        private System.Windows.Forms.PictureBox pbxMainChildForm;
        private System.Windows.Forms.Button btnBackMain;
    }
}

