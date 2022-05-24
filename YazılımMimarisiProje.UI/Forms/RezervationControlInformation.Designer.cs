
namespace YazılımMimarisiProje.UI.Forms
{
    partial class RezervationControlInformation
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgwReservationInformation = new System.Windows.Forms.DataGridView();
            this.dgwUserInformation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReservationInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInformation.Location = new System.Drawing.Point(12, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(218, 15);
            this.lblInformation.TabIndex = 35;
            this.lblInformation.Text = "Raporunuzu hangi formatta istersiniz ?\r\n";
            // 
            // btnJson
            // 
            this.btnJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnJson.FlatAppearance.BorderSize = 0;
            this.btnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJson.ForeColor = System.Drawing.Color.White;
            this.btnJson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJson.Location = new System.Drawing.Point(12, 42);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(65, 33);
            this.btnJson.TabIndex = 40;
            this.btnJson.Text = "JSON";
            this.btnJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJson.UseVisualStyleBackColor = false;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnXml.FlatAppearance.BorderSize = 0;
            this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXml.ForeColor = System.Drawing.Color.White;
            this.btnXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXml.Location = new System.Drawing.Point(110, 42);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(65, 33);
            this.btnXml.TabIndex = 41;
            this.btnXml.Text = "XML";
            this.btnXml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(199, 40);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(136, 35);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "EXCEL WORD PDF\r\n";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgwReservationInformation
            // 
            this.dgwReservationInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReservationInformation.Location = new System.Drawing.Point(15, 44);
            this.dgwReservationInformation.Name = "dgwReservationInformation";
            this.dgwReservationInformation.Size = new System.Drawing.Size(54, 31);
            this.dgwReservationInformation.TabIndex = 44;
            this.dgwReservationInformation.Visible = false;
            // 
            // dgwUserInformation
            // 
            this.dgwUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUserInformation.Location = new System.Drawing.Point(250, 49);
            this.dgwUserInformation.Name = "dgwUserInformation";
            this.dgwUserInformation.Size = new System.Drawing.Size(62, 26);
            this.dgwUserInformation.TabIndex = 45;
            this.dgwUserInformation.Visible = false;
            // 
            // RezervationControlInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(354, 96);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.dgwReservationInformation);
            this.Controls.Add(this.dgwUserInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervationControlInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervationControlInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dgwReservationInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgwReservationInformation;
        private System.Windows.Forms.DataGridView dgwUserInformation;
    }
}