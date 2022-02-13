using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Log_In;
using Microsoft.VisualBasic.ApplicationServices;

namespace DSQL_Users
{
    class DbSqlServerUsers
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        public DbSqlServerUsers()
        {
            con = new SqlConnection(connstring);
        }

        public void Create(Users user)
        {

            string strInsert =
            "insert into Users values ("
            + "'" + user.Id + "', '" + user.Email + "', '" + user.Password +
           "')";

            SqlCommand cmd = new SqlCommand(strInsert, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public List<Users> GetAll()
        {
            SqlDataReader rdr;
            List<Users> list = new List<Users>();
            using
            (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text;// implicit
                cmd.Connection = con;
                cmd.CommandText = "select * from Users";
                con.Open();
                rdr = cmd.ExecuteReader();



                while (rdr.Read())
                {
                    Users users = new Users();
                    users.Id = (int)rdr["Id"];
                    users.Email = (string)rdr["Email"];
                    users.Password = (string)rdr["Password"];
                    list.Add(users);
                }


                rdr.Close();
                con.Close();
                return list;
            }
        }
    }
}

namespace DSQL_Accounts
{
    class DbSqlServerAccounts
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        public DbSqlServerAccounts()
        {
            con = new SqlConnection(connstring);
        }

        public void Create(Accounts account)
        {
            string strInsert =
            "insert into Accounts values ("
            + "'" + account.Id + "', '" + account.Nume + "', '" + account.Prenume
            + "','" + account.Email + "', '" + account.Telefon + "', '" + account.Adresa
            + "','" + account.Oras + "', '" + account.Tara + "', '" + account.CodPostal
            + "','" + account.Picture + "', '" + account.AccountBalance + "')";

            SqlCommand cmd = new SqlCommand(strInsert, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public Accounts GetAccount(int id)
        {
            SqlDataReader rdr;
            Accounts account = new Accounts();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;// implicit
            cmd.Connection = con;
            cmd.CommandText = "select * from Accounts where Id='" + id + "'";
            con.Open();
            rdr = cmd.ExecuteReader();



            while (rdr.Read())
            {

                account.Id = id;
                account.Nume = (string)rdr["Nume"];
                account.Prenume = (string)rdr["Prenume"];
                account.Email = (string)rdr["Email"];
                account.Telefon = (string)rdr["Telefon"];
                account.Adresa = (string)rdr["Adresa"];
                account.Oras = (string)rdr["Oras"];
                account.Tara = (string)rdr["Tara"];
                account.CodPostal = (string)rdr["Cod_postal"];
                account.Picture = (string)rdr["Picture"];
                account.AccountBalance = (int)rdr["AccountBalance"];
            }


            rdr.Close();
            con.Close();
            return account;
        }


        public void UpdateAccountBalance(int id, int val)
        {
            string strUpdate;
            int n;
            SqlCommand cmd;

            strUpdate = "update Accounts set AccountBalance= AccountBalance+'" +   //Nume
            val + "' where Id='" + id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();
        }





        public void UpdateAccountBalanceMinus(int id, int val)
        {
            string strUpdate;
            int n;
            SqlCommand cmd;

            strUpdate = "update Accounts set AccountBalance= AccountBalance-'" +   //Nume
            val + "' where Id='" + id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();
        }



        public void Update(Accounts account)
        {
            string strUpdate;
            int n;
            SqlCommand cmd;

            strUpdate = "update Accounts set Nume= '" +   //Nume
            account.Nume + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();

            strUpdate = "update Accounts set Prenume= '" +   //Prenume
            account.Prenume + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();


            strUpdate = "update Accounts set Email= '" +   //Email
            account.Email + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();


            strUpdate = "update Accounts set Telefon= '" +   //Telefon
            account.Telefon + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();


            strUpdate = "update Accounts set Adresa= '" +   //Adresa
            account.Adresa + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();


            strUpdate = "update Accounts set Oras= '" +   //Oras
            account.Oras + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();


            strUpdate = "update Accounts set Tara= '" +   //Tara
            account.Tara + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();


            strUpdate = "update Accounts set Cod_postal= '" +   //Cod Postal
            account.CodPostal + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }
            con.Close();


            strUpdate = "update Accounts set Picture= '" +   //Picture
           account.Picture + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();

            strUpdate = "update Accounts set AccountBalance= '" +   //Account Balance
           account.AccountBalance + "' where Id='" + account.Id + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();
        }

    }
}

namespace StoredProcedure
{
    public class Procedure
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        public Procedure()
        {
            con = new SqlConnection(connstring);
        }

        public int tarif(int param)
        {
            int val;
            SqlCommand cmd = new SqlCommand("select tarif from Rooms where TipCamera='" + param + "'", con);
            con.Open();

            val = (int)cmd.ExecuteScalar();


            con.Close();
            return val;

        }
        public string totalPlata(string datamin, string datamax, int tarif)
        {
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("totalPlata", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.CommandText = "totalPlata";


            SqlParameter p1 = new SqlParameter();
            p1.Value = datamin;
            p1.ParameterName = "@datamin";
            sql_cmnd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.Value = datamax;
            p2.ParameterName = "@datamax";
            sql_cmnd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.Value = tarif;
            p3.ParameterName = "@tarif";
            sql_cmnd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.DbType = DbType.Int32;
            p4.ParameterName = "@result";
            p4.Direction = ParameterDirection.Output;
            sql_cmnd.Parameters.Add(p4);

            sql_cmnd.ExecuteScalar();

            //SqlCommand cmd = new SqlCommand("declare @ResultP int EXEC totalPlata @datamin='" + datamin + "',@datamax='" + datamax + "',@tarif=" + tarif+ "select @ResultP", con);

            //cmd.ExecuteNonQuery();
            con.Close();
            return p4.Value.ToString();

        }
    }
}

namespace DSQL_Rooms
{
    public class DbSqlServerRooms
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        public DbSqlServerRooms()
        {
            con = new SqlConnection(connstring);
        }

        public void setRoomsNumber(int type)
        {
            string strUpdate;
            int n;
            SqlCommand cmd;

            strUpdate = "update Rooms set NrCamere= NrCamere-1 where TipCamera='" + type + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();
        }


        public void setRoomsDisponibility(string noCamera)
        {
            string strUpdate;
            int n;
            SqlCommand cmd;

            strUpdate = "update TotalRooms set Disponibility= 'Busy' where RoomNumber='" + noCamera + "'";
            try
            {
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                n = cmd.ExecuteNonQuery(); //nr randuri afectate
                if (n == 0) throw new Exception("Id inexistent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: Modificare esuata\n" +
                strUpdate + "\n" + e.ToString());
            }

            con.Close();
        }

        public int TypeCamera(int id)
        {
            int val;
            SqlCommand cmd = new SqlCommand("select TipulCamerei from HistoryReservation where IdBeneficiar='" + id + "'", con);
            con.Open();
            val = (int)cmd.ExecuteScalar();
            con.Close();
            return val;
        }

        public string NumberRoom(int id)
        {
            string val;
            SqlCommand cmd = new SqlCommand("select NumarulCamerei from HistoryReservation where IdBeneficiar='" + id + "'", con);
            con.Open();
            val = (string)cmd.ExecuteScalar();
            con.Close();
            return val;
        }
    }
}

namespace DBSQL_Reservation
{
    public class DbSqlServerReservation
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        public DbSqlServerReservation()
        {
            con = new SqlConnection(connstring);
        }

        public void Create(int id, DateTime dataSosire, DateTime dataPlecare, string nrCamera, int tipCamera, int totalPlata, int idBeneficiar)
        {
            string strInsert =
            "insert into HistoryReservation values (" + "'" + id + "', '"
            + dataSosire + "', '" + dataPlecare + "', '" + nrCamera + "', '" + tipCamera + "', '" + totalPlata + "', '" + idBeneficiar +
           "')";

            SqlCommand cmd = new SqlCommand(strInsert, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<ReservationHistory> GetReservation(int id)
        {
            SqlDataReader rdr;

            List<ReservationHistory> list = new List<ReservationHistory>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;// implicit
            cmd.Connection = con;
            cmd.CommandText = "select * from HistoryReservation where IdBeneficiar='" + id + "'";
            con.Open();
            rdr = cmd.ExecuteReader();



            while (rdr.Read())
            {
                ReservationHistory rezervare = new ReservationHistory();
                rezervare.Id = (int)rdr["Id"];
                rezervare.dataSosire = (DateTime)rdr["DataSosire"];
                rezervare.dataPlecare = (DateTime)rdr["DataPlecare"];
                rezervare.NoRoom = (string)rdr["NumarulCamerei"];
                rezervare.TypeRoom = (int)rdr["TipulCamerei"];
                rezervare.totalPlata = (int)rdr["TotalPlata"];
                rezervare.idBeneficiar = (int)rdr["IdBeneficiar"];

                list.Add(rezervare);
            }


            rdr.Close();
            con.Close();
            return list;
        }


        public List<ReservationHistory> GetReservation()
        {
            SqlDataReader rdr;

            List<ReservationHistory> list = new List<ReservationHistory>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;// implicit
            cmd.Connection = con;
            cmd.CommandText = "select * from HistoryReservation";
            con.Open();
            rdr = cmd.ExecuteReader();



            while (rdr.Read())
            {
                ReservationHistory rezervare = new ReservationHistory();
                rezervare.Id = (int)rdr["Id"];
                rezervare.dataSosire = (DateTime)rdr["DataSosire"];
                rezervare.dataPlecare = (DateTime)rdr["DataPlecare"];
                rezervare.NoRoom = (string)rdr["NumarulCamerei"];
                rezervare.TypeRoom = (int)rdr["TipulCamerei"];
                rezervare.totalPlata = (int)rdr["TotalPlata"];
                rezervare.idBeneficiar = (int)rdr["IdBeneficiar"];

                list.Add(rezervare);
            }


            rdr.Close();
            con.Close();
            return list;
        }
    }
}
