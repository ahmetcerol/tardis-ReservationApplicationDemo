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

namespace YazılımMimarisiProje.UI
{
    public partial class MainPage : Form
    {
        private Form activateForm;
        public MainPage()
        {
            InitializeComponent();
            btnClose.Image = ımgListOfMainPage.Images[0];
            btnMaximize.Image = ımgListOfMainPage.Images[2];
            btnMinimize.Image = ımgListOfMainPage.Images[1];
           
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
            this.pnlChildForms.Controls.Add(childForm);
            this.pnlChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reservation(), sender);
        }

        private void btnReservationControl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReservationControl(), sender);
        }

        private void btnReservationCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReservationDelete(), sender);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
            {
                activateForm.Close();

            }
           
        }
    }
}
