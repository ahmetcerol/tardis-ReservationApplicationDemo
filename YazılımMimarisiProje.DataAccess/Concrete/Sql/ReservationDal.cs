using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiProje.DataAccess.Abstract;
using YazılımMimarisiProje.Entity.Concrete;

namespace YazılımMimarisiProje.DataAccess.Concrete.Sql
{
    public class ReservationDal:IReservationDal
    {
        SqlConnection aconnection = new SqlConnection
           (@"server=(localdb)\mssqllocaldb; initial catalog=TardisDatabase; integrated security=true");
        private void ConnectionControl()
        {
            if (aconnection.State == ConnectionState.Closed)
            {
                aconnection.Open();
            }
        }

        public List<ReservationInformation> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Reservation ", aconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<ReservationInformation> reservationInformation = new List<ReservationInformation>();
            while (reader.Read())
            {
                ReservationInformation reservationInformations = new ReservationInformation()
                {
                    ReservationId = Convert.ToInt32(reader["ReservationId"]),
                    ReservationAccomodation = reader["ReservationAccomodation"].ToString(),
                    ReservationTransportation = reader["ReservationTransportation"].ToString(),
                    ReservationEntranceDate = Convert.ToDateTime(reader["ReservationEntranceDate"]),
                    ReservationQuitDate= Convert.ToDateTime(reader["ReservationQuitDate"]),
                    ReservationPrice=Convert.ToInt32(reader["ReservationPrice"]),

                };
                reservationInformation.Add(reservationInformations);

            }
            reader.Close();
            aconnection.Close();

            return reservationInformation;
        }
        public void Add(ReservationInformation reservationInformation)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Reservation values(@ReservationAccomodation, @ReservationTransportation, @ReservationEntranceDate, @ReservationQuitDate, @ReservationPrice)", aconnection);
            command.Parameters.AddWithValue("@ReservationAccomodation", reservationInformation.ReservationAccomodation);
            command.Parameters.AddWithValue("@ReservationTransportation", reservationInformation.ReservationTransportation);
            command.Parameters.AddWithValue("@ReservationEntranceDate", reservationInformation.ReservationEntranceDate);
            command.Parameters.AddWithValue("@ReservationQuitDate", reservationInformation.ReservationQuitDate);
            command.Parameters.AddWithValue("@ReservationPrice", reservationInformation.ReservationPrice);
            command.ExecuteNonQuery();
            aconnection.Close();
        }

        public void Delete(string BookerEmail)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Booker Where BookerEmail=@BookerEmail", aconnection);
            command.Parameters.AddWithValue("@BookerEmail", BookerEmail);
            command.ExecuteNonQuery();
            aconnection.Close();
        }
    }
}
