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
           (@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\YazılımMimarisiProke\YazılımMimarisiProje.DataAccess\SoftwareArchitecture.mdf;Integrated Security=True");
            
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
            SqlCommand command = new SqlCommand("Select * from Bilgiler ", aconnection);
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
        public void Add(ReservationInformation reservationInformation,Booker booker)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Bilgiler Values(@ReservationAccomodation, @ReservationTransportation, @ReservationEntranceDate, @ReservationQuitDate, @ReservationPrice,@BookerName, @BookerSurname, @BookerEmail, @BookerTcNo, @BookerPhoneNumber)", aconnection);
            command.Parameters.AddWithValue("@ReservationAccomodation", reservationInformation.ReservationAccomodation);
            command.Parameters.AddWithValue("@ReservationTransportation", reservationInformation.ReservationTransportation);
            command.Parameters.AddWithValue("@ReservationEntranceDate", reservationInformation.ReservationEntranceDate);
            command.Parameters.AddWithValue("@ReservationQuitDate", reservationInformation.ReservationQuitDate);
            command.Parameters.AddWithValue("@ReservationPrice", reservationInformation.ReservationPrice);
            command.Parameters.AddWithValue("@BookerName", booker.BookerName);
            command.Parameters.AddWithValue("@BookerSurname", booker.BookerSurname);
            command.Parameters.AddWithValue("@BookerEmail", booker.BookerEmail);
            command.Parameters.AddWithValue("@BookerTcNo", booker.BookerTcNo);
            command.Parameters.AddWithValue("@BookerPhoneNumber", booker.BookerPhoneNumber);
            command.ExecuteNonQuery();
            aconnection.Close();
        }

        public void Add(Booker booker)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Booker Values(@BookerName, @BookerSurname, @BookerEmail, @BookerTcNo, @BookerPhoneNumber)", aconnection);
            command.Parameters.AddWithValue("@BookerName",booker.BookerName);
            command.Parameters.AddWithValue("@BookerSurname",booker.BookerSurname);
            command.Parameters.AddWithValue("@BookerEmail",booker.BookerEmail );
            command.Parameters.AddWithValue("@BookerTcNo", booker.BookerTcNo);
            command.Parameters.AddWithValue("@BookerPhoneNumber", booker.BookerPhoneNumber);
            command.ExecuteNonQuery();
            aconnection.Close();
        }

        public List<ReservationInformation> GetUserInformation(string BookerEmail)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select RezervationAccomodation,RezervationTransportation,RezervationEntranceDate,RezervationQuitDate,RezervationPrice from Bilgiler Where BookerEmail=@BookerEmail", aconnection);
            command.Parameters.AddWithValue("@BookerEmail", BookerEmail);
            SqlDataReader reader = command.ExecuteReader();
            List<ReservationInformation> user = new List<ReservationInformation>();
            while (reader.Read())
            {
                ReservationInformation users = new ReservationInformation()
                {
                    ReservationAccomodation = reader["RezervationAccomodation"].ToString(),
                    ReservationTransportation = reader["RezervationTransportation"].ToString(),
                    ReservationEntranceDate = Convert.ToDateTime(reader["RezervationEntranceDate"]),
                    ReservationQuitDate = Convert.ToDateTime(reader["RezervationQuitDate"]),
                    ReservationPrice = Convert.ToInt32(reader["RezervationPrice"]),

                };
                user.Add(users);

            }
            reader.Close();
            aconnection.Close();

            return user;
        }

        public List<Booker> GetReservationInformation(string BookerEmail)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select BookerName,BookerSurname,BookerEmail,BookerPhoneNumber from Bilgiler Where BookerEmail=@BookerEmail", aconnection);
            command.Parameters.AddWithValue("@BookerEmail", BookerEmail);
            SqlDataReader reader = command.ExecuteReader();
            List<Booker> user = new List<Booker>();
            while (reader.Read())
            {
                Booker users = new Booker()
                {
                    BookerName = reader["BookerName"].ToString(),
                    BookerSurname = reader["BookerSurname"].ToString(),
                    BookerPhoneNumber = Convert.ToInt32(reader["BookerPhoneNumber"]),
                    BookerEmail = reader["BookerEmail"].ToString(),
                    

                };
                user.Add(users);

            }
            reader.Close();
            aconnection.Close();

            return user;
        }


        public void Delete(string BookerEmail)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Bilgiler Where BookerEmail=@BookerEmail", aconnection);
            command.Parameters.AddWithValue("@BookerEmail", BookerEmail);
            command.ExecuteNonQuery();
            aconnection.Close();
        }


    }
}
