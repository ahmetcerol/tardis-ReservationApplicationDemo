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
    public partial class AboutReservation : Form
    {
        private string UserEmail;
        private string _userName;
        private string _userSurname;
        private int _tcNo;
        private int _phoneNumber;
        private Form activateForm;
        public AboutReservation(string User,string UserName,string UserSurname,int TcNO,int PhoneNumber)
        {
            UserEmail = User;
            _userName = UserName;
            _userSurname = UserSurname;
            _tcNo = TcNO;
            _phoneNumber = PhoneNumber;
            InitializeComponent();
            _reservationService = new ReservationManager(new ReservationDal());
        }
        private IReservationService _reservationService;
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
            _reservationService.Add(new ReservationInformation
            {
                ReservationAccomodation = tbxAccomodation.Text,
                ReservationTransportation = tbxTransportation.Text,
                ReservationEntranceDate = Convert.ToDateTime(tbxEnterDate.Text),
                ReservationQuitDate = Convert.ToDateTime(tbxQuitDate.Text),
                ReservationPrice = Reservation.Price,

            }, new Booker
            {
                BookerName = _userName,
                BookerSurname = _userSurname,
                BookerEmail = UserEmail,
                BookerPhoneNumber = _phoneNumber,
                BookerTcNo = _tcNo,
            }) ;
            
            MessageBox.Show(_userName+"  Bey/Hanımefendi rezervasyon işleminiz başarıyla gerçekleşmiştir.\n" +
                "Bizi tercih ettiğiniz için teşekkür ederiz.");
            OpenChildForm(new Forms.Reservation());
        }
    }
}
