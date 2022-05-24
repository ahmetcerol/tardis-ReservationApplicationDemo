using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using YazılımMimarisiProje.Bussiness.Abstract;
using YazılımMimarisiProje.Bussiness.Concrete;
using YazılımMimarisiProje.DataAccess.Concrete.Sql;
using YazılımMimarisiProje.Entity.Concrete;
using YazılımMimarisiProje.Entity.Abstract;




namespace YazılımMimarisiProje.UI.Forms
{
    public partial class RezervationControlInformation : Form
    {
        private string Booker;
        ReservationInformation reservationInformation = new ReservationInformation();
        Booker booker = new Booker();
        public RezervationControlInformation(string BookerEmail)
        {
            Booker = BookerEmail;
            InitializeComponent();
            _reservationDal = new ReservationManager(new ReservationDal());
            GetReservationInformation();
            GetUSerInformation();

        }

        private void GetUSerInformation()
        {
            dgwUserInformation.DataSource = _reservationDal.GetReservationInformation(Booker);
            booker.BookerName = dgwUserInformation.Rows[0].Cells[1].Value.ToString();
            booker.BookerSurname = dgwUserInformation.Rows[0].Cells[2].Value.ToString();
            booker.BookerEmail = dgwUserInformation.Rows[0].Cells[3].Value.ToString();
            booker.BookerPhoneNumber = Convert.ToInt32(dgwUserInformation.Rows[0].Cells[5].Value);
        }

        private void GetReservationInformation()
        {
            dgwReservationInformation.DataSource = _reservationDal.GetUserInformation(Booker);
            reservationInformation.ReservationAccomodation = dgwReservationInformation.Rows[0].Cells[1].Value.ToString();
            reservationInformation.ReservationTransportation = dgwReservationInformation.Rows[0].Cells[2].Value.ToString();
            reservationInformation.ReservationEntranceDate = Convert.ToDateTime(dgwReservationInformation.Rows[0].Cells[3].Value);
            reservationInformation.ReservationQuitDate = Convert.ToDateTime(dgwReservationInformation.Rows[0].Cells[4].Value);
            reservationInformation.ReservationPrice = Convert.ToInt32(dgwReservationInformation.Rows[0].Cells[5].Value);
        }

        private IReservationService _reservationDal;

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
            this.Close();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
           
            IReservationBuilder reservationBuilder = new JSONConcreteBuilder(reservationInformation,booker);
            ReservationInformationDırector reservationInformationDırector = new ReservationInformationDırector();
            reservationInformationDırector.Uret(reservationBuilder);

            string stringJSON = JsonConvert.SerializeObject(reservationInformation);
            string path = @"C:\Users\hp\Desktop\reservation.json";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(stringJSON.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(stringJSON.ToString());
                    tw.Close();
                }
            }
            MessageBox.Show("Başarıyla Oluşturuldu!");
            this.Close();
        }

       

        private void btnXml_Click(object sender, EventArgs e)
        {
            IReservationBuilder reservationBuilder = new XMLConcreteBuilder(reservationInformation, booker);
            ReservationInformationDırector reservationInformationDırector = new ReservationInformationDırector();
            reservationInformationDırector.Uret(reservationBuilder);

            Stream stream = new FileStream("BasicSerialization.xml", FileMode.Create, FileAccess.Write, FileShare.Write);
            XmlSerializer xmlserializer = new XmlSerializer(typeof(ReservationInformation));
            xmlserializer.Serialize(stream, reservationInformation);
            stream.Close();
            MessageBox.Show("Xml dosyası başarıyla oluşturuldu.");
            this.Close();
        }

      
    }
}
