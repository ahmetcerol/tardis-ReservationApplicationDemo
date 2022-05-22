using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace YazılımMimarisiProje.UI.Forms
{
    public partial class ReservationControl : Form
    {
        private Form activateForm;
        public ReservationControl()
        {
            InitializeComponent();
        }

        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
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
            if (tbxEmail.Text==string.Empty||tbxPersonalIdentificationNo.Text==String.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
            else if (SayiMi(tbxPersonalIdentificationNo.Text) != true)
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru dolduruğunuza emin olun!");
            }
            else
            {
                RezervationControlInformation rezervationControlInformation = new RezervationControlInformation(tbxEmail.Text);
                rezervationControlInformation.ShowDialog();
            }
           
        }
    }
}
