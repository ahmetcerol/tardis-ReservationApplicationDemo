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
    public partial class AboutReservation : Form
    {
        private string UserEmail;
        private Form activateForm;
        public AboutReservation(string User)
        {
            UserEmail = User;
            InitializeComponent();
        }

        private void AboutReservation_Load(object sender, EventArgs e)
        {
            tbxEnterDate.Text = Reservation.DateTimeQuit.ToString();
            tbxQuitDate.Text = Reservation.dateTimeEntrance.ToString();
            tbxAccomodation.Text = Reservation.Accomodation;
            tbxTransportation.Text = Reservation.Transportation;
            tbxEmail.Text = UserEmail;
            lblPrice.Text = Reservation.Price.ToString()+"TL";
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
            this.pnlAboutReservation.Controls.Add(childForm);
            this.pnlAboutReservation.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervasyon işleminiz başarıyla gerçeklemiştir.\n" +
                "Bizi Tercih Ettiğiniz için teşekkür ederiz.");
            OpenChildForm(new Forms.Reservation());
        }
    }
}
