using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.UI.Forms
{
    public partial class ReservationPersonalInformation : Form
    {
        private Form activateForm;
      
        public ReservationPersonalInformation()
        {
            
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlReservationPersonelInformation.Controls.Add(childForm);
            this.pnlReservationPersonelInformation.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbxEmail.Text == String.Empty || tbxName.Text == String.Empty || tbxPersonalIdentificationNo.Text == String.Empty || tbxPhoneNumber.Text == String.Empty || tbxSurname.Text == String.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            else
            {
                try
                {
                    OpenChildForm(new Forms.AboutReservation(tbxEmail.Text, tbxName.Text, tbxSurname.Text, Convert.ToInt32(tbxPersonalIdentificationNo.Text), Convert.ToInt32(tbxPhoneNumber.Text)), sender);
                }

                catch (Exception)
                {

                    MessageBox.Show("Lütfen alanları doğru doldurduğunuza emin olunuz!");
                }


            }
        }
    }
}
