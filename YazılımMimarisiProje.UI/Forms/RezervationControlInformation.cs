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




namespace YazılımMimarisiProje.UI.Forms
{
    public partial class RezervationControlInformation : Form
    {
        private string Booker;
        public RezervationControlInformation(string BookerEmail)
        {
            Booker = BookerEmail;
            InitializeComponent();
            _reservationDal = new ReservationManager(new ReservationDal());
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
            dataGridView1.DataSource = _reservationDal.GetUserInformation(Booker);
            ReservationInformation reservationInformation = new ReservationInformation() {
            
            ReservationAccomodation = dataGridView1.Rows[0].Cells[1].Value.ToString(),
            ReservationTransportation = dataGridView1.Rows[0].Cells[2].Value.ToString(),
            ReservationEntranceDate = Convert.ToDateTime(dataGridView1.Rows[0].Cells[3].Value),
            ReservationQuitDate = Convert.ToDateTime(dataGridView1.Rows[0].Cells[4].Value),
            ReservationPrice = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value),
        };
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
            dataGridView1.DataSource = _reservationDal.GetUserInformation(Booker);
            ReservationInformation reservationInformation = new ReservationInformation()
            {

                ReservationAccomodation = dataGridView1.Rows[0].Cells[1].Value.ToString(),
                ReservationTransportation = dataGridView1.Rows[0].Cells[2].Value.ToString(),
                ReservationEntranceDate = Convert.ToDateTime(dataGridView1.Rows[0].Cells[3].Value),
                ReservationQuitDate = Convert.ToDateTime(dataGridView1.Rows[0].Cells[4].Value),
                ReservationPrice = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value),
            };
                
            Stream stream = new FileStream("BasicSerialization.xml", FileMode.Create, FileAccess.Write, FileShare.Write);
            XmlSerializer xmlserializer = new XmlSerializer(typeof(ReservationInformation));
            xmlserializer.Serialize(stream, reservationInformation);
            stream.Close();
            MessageBox.Show("Xml dosyası başarıyla oluşturuldu.");
            this.Close();
        }
    }
}
