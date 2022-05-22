
namespace YazılımMimarisiProje.UI.Forms
{
    partial class ReservationDeleteConfirmation
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
            this.btnApproval = new System.Windows.Forms.Button();
            this.btnDisapproval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInformation.Location = new System.Drawing.Point(11, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(295, 30);
            this.lblInformation.TabIndex = 34;
            this.lblInformation.Text = "Rezervasyonunuzu silmek istediğinize emin misiniz?\r\n(Konaklama ve Ulaşım rezervas" +
    "yonunuz silinecektir!)\r\n";
            // 
            // btnApproval
            // 
            this.btnApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnApproval.FlatAppearance.BorderSize = 0;
            this.btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApproval.ForeColor = System.Drawing.Color.White;
            this.btnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproval.Location = new System.Drawing.Point(181, 47);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(98, 33);
            this.btnApproval.TabIndex = 38;
            this.btnApproval.Text = "Evet";
            this.btnApproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApproval.UseVisualStyleBackColor = false;
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // btnDisapproval
            // 
            this.btnDisapproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnDisapproval.FlatAppearance.BorderSize = 0;
            this.btnDisapproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisapproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisapproval.ForeColor = System.Drawing.Color.White;
            this.btnDisapproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisapproval.Location = new System.Drawing.Point(40, 47);
            this.btnDisapproval.Name = "btnDisapproval";
            this.btnDisapproval.Size = new System.Drawing.Size(98, 33);
            this.btnDisapproval.TabIndex = 39;
            this.btnDisapproval.Text = "Hayır";
            this.btnDisapproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisapproval.UseVisualStyleBackColor = false;
            this.btnDisapproval.Click += new System.EventHandler(this.btnDisapproval_Click);
            // 
            // ReservationDeleteConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 94);
            this.Controls.Add(this.btnDisapproval);
            this.Controls.Add(this.btnApproval);
            this.Controls.Add(this.lblInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationDeleteConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationDeleteConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Button btnDisapproval;
    }
}