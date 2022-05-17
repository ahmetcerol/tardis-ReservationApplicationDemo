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
    public partial class ReservationDelete : Form
    {

        
        public ReservationDelete()
        {
            InitializeComponent();
            
        }
        private string BookerEmail;
     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxEmail.Text==String.Empty||tbxPersonalIdentificationNo.Text==String.Empty)
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!");
            }
            else
            {
                BookerEmail = tbxEmail.Text;
                ReservationDeleteConfirmation reservationDeleteConfirmation = new ReservationDeleteConfirmation(BookerEmail);
                reservationDeleteConfirmation.ShowDialog();
                tbxEmail.Text = String.Empty;
                tbxPersonalIdentificationNo.Text = String.Empty;
                
            }
          
        }
    }
}
