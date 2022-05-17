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

namespace YazılımMimarisiProje.UI.Forms
{
    public partial class ReservationDeleteConfirmation : Form
    {
        private string DeleteBooker;
        private IReservationService _reservationService;

       
        public ReservationDeleteConfirmation(string BookerEmail)
        {
            DeleteBooker = BookerEmail;
            InitializeComponent();
            _reservationService = new ReservationManager(new ReservationDal());
        }

        private void btnDisapproval_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btnApproval_Click(object sender, EventArgs e)
        {
            try
            {
                _reservationService.Delete(DeleteBooker);
                MessageBox.Show("Rezervasyonunuz başarıyla iptal edildi");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Reservasyonunuz bulunamadı");
                 
            } 
        }
    }
}
