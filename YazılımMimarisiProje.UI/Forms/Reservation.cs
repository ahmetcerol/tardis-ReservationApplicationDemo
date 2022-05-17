using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımMimarisiProje.Bussiness.Abstract;
using YazılımMimarisiProje.Bussiness.Concrete;
using YazılımMimarisiProje.DataAccess.Concrete.Sql;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.UI.Forms
{
    public partial class Reservation : Form
          
    {
        private Form activateForm;
        private IReservationService _reservationService;
        public Reservation()
        {
            _reservationService = new ReservationManager(new ReservationDal());
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
            this.pnlGetingReservation.Controls.Add(childForm);
            this.pnlGetingReservation.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public static DateTime DateTimeQuit;
        private TimeSpan DateTimeEntrance;
        public static int Price;
        public static string Accomodation;
        public static string Transportation;
        public static DateTime dateTimeEntrance;


        private void btnForward_Click(object sender, EventArgs e)
        {

            if (cbxAccomodation.SelectedIndex == -1 || cbxTransportation.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
            }
            else
            {
                PriceChecker();
                OpenChildForm(new Forms.ReservationPersonalInformation(), sender);
            }
            
        }

       
        
        private void PriceChecker()
        {
            Accomodation = cbxAccomodation.SelectedItem.ToString();
            Transportation = cbxTransportation.SelectedItem.ToString();
            dateTimeEntrance = dtpQuit.Value;
            DateTimeQuit = Convert.ToDateTime(dtpEnter.Text);
            DateTimeEntrance = Convert.ToDateTime(dtpQuit.Text).Subtract(DateTimeQuit);
            Price =150*( Convert.ToInt32(DateTimeEntrance.TotalDays));
        }
             
    }
}
