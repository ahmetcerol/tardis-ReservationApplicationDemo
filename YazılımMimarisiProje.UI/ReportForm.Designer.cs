
namespace YazılımMimarisiProje.UI
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.BilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SoftwareArchitectureDataSet = new YazılımMimarisiProje.UI.SoftwareArchitectureDataSet();
            this.rpwRezervation = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BilgilerTableAdapter = new YazılımMimarisiProje.UI.SoftwareArchitectureDataSetTableAdapters.BilgilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BilgilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareArchitectureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BilgilerBindingSource
            // 
            this.BilgilerBindingSource.DataMember = "Bilgiler";
            this.BilgilerBindingSource.DataSource = this.SoftwareArchitectureDataSet;
            // 
            // SoftwareArchitectureDataSet
            // 
            this.SoftwareArchitectureDataSet.DataSetName = "SoftwareArchitectureDataSet";
            this.SoftwareArchitectureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpwRezervation
            // 
            this.rpwRezervation.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BilgilerBindingSource;
            this.rpwRezervation.LocalReport.DataSources.Add(reportDataSource1);
            this.rpwRezervation.LocalReport.ReportEmbeddedResource = "YazılımMimarisiProje.UI.Reports.RezervationReport.rdlc";
            this.rpwRezervation.Location = new System.Drawing.Point(0, 0);
            this.rpwRezervation.Name = "rpwRezervation";
            this.rpwRezervation.ServerReport.BearerToken = null;
            this.rpwRezervation.Size = new System.Drawing.Size(800, 450);
            this.rpwRezervation.TabIndex = 0;
            // 
            // BilgilerTableAdapter
            // 
            this.BilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpwRezervation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tardis Rapor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BilgilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareArchitectureDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwRezervation;
        private System.Windows.Forms.BindingSource BilgilerBindingSource;
        private SoftwareArchitectureDataSet SoftwareArchitectureDataSet;
        private SoftwareArchitectureDataSetTableAdapters.BilgilerTableAdapter BilgilerTableAdapter;
    }
}