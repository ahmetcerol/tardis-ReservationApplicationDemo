using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMimarisiProje.UI.Forms
{
    public partial class ReservationControl : Form
    {
        private Form activateForm;
        public ReservationControl()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlRezervationControl.Controls.Add(childForm);
            this.pnlRezervationControl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnGetADocument_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportForm());
        }
    }
}
