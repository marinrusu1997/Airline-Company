using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.IO;



namespace Proiect_PAW
{
    public static class DBRepositoriesManager
    {

        public static bool IsOpen
        {
            get
            {
                if (DBConnection == null)
                    return false;
                return DBConnection.State == System.Data.ConnectionState.Open;
            }
        }

        private static SqlConnection DBConnection = null;
        private static SqlCommand DBCommand = new SqlCommand();
        private static FileInfo SQLExeptionsFile = new FileInfo("DBExceptions.txt");

        public static bool OpenAirCompanyDB()
        {
            if (DBConnection == null)
                DBConnection = new SqlConnection(@Properties.Settings.Default.AirCompanyDb);
            if (DBConnection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    DBConnection.Open();
                    return true;
                }
                catch (SqlException e)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName, Environment.NewLine + DateTime.Now.ToString() +
                        Environment.NewLine + e.Message, Encoding.Unicode);
                    return false;
                }
            }
            else if (DBConnection.State == System.Data.ConnectionState.Open)
                return true;
            return false;
        }

        public static void CloseAirCompanyDB()
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
                DBConnection.Close();
        }

        public static int AirCompanyDBExecuteNonQuerry(string command)
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                DBCommand.CommandText = command;
                DBCommand.Connection = DBConnection;
                try
                {
                    return DBCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName, Environment.NewLine + DateTime.Now.ToString() +
                        Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    return -1;
                }
            }
            return -1;
        }
        public static int AirCompanyDBExecuteNonQuerry(SqlCommand command)
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                command.Connection = DBConnection;
                try
                {
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName,
                        Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    return -1;
                }
            }
            return -1;
        }

        public static SqlDataReader AirCompanyDBExecuteReader(string command)
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                DBCommand.CommandText = command;
                DBCommand.Connection = DBConnection;
                try
                {
                    return DBCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName, Environment.NewLine + DateTime.Now.ToString() +
                        Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    return null;
                }
            }
            return null;
        }

        public static object AirCompanyDBExecuteScalar(string command)
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                DBCommand.CommandText = command;
                DBCommand.Connection = DBConnection;
                try
                {
                    return DBCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName,
                        Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    return null;
                }
            }
            return null;
        }
        public static object AirCompanyDBExecuteScalar(SqlCommand command)
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                command.Connection = DBConnection;
                try
                {
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName,
                        Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    return null;
                }
            }
            return null;
        }
        public static int AirCompanyDBAddRezervant(Persoana persoana)
        {

            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                DBCommand.CommandText = "INSERT INTO REZERVANTI" +
                      "(NUME,PRENUME,EMAIL,CETATENIE,DATA_NASTERE,NUMAR_PASAPORT,TELEFON,CNP,SEX) VALUES"
                      + "('" + persoana.Nume + "','" + persoana.Prenume + "','" + persoana.Email + "','" +
                      persoana.Cetatenie + "','" +
                      persoana.DataNastere.ToString("yyyy-MM-dd") + "','" + persoana.NumarPasaport +
                      "','" +
                      persoana.Telefon + "','" +
                      persoana.CNP + "','" + persoana.Sex + "')";
                DBCommand.Connection = DBConnection;
                try
                {
                    return DBCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName,
                        Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    return -1;
                }
            }
            return -1;
        }

        public static Persoana AirCompanyDBGetPersoana(string CNP)
        {
            if (DBConnection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    Persoana p;
                    SqlCommand commandClienti = new SqlCommand();
                    commandClienti.Connection = DBConnection;
                    commandClienti.CommandText = "SELECT * FROM CLIENTI WHERE CNP='" + CNP + "'";
                    //commandClienti.Parameters.Add("@cnp_cautatGetPers", SqlDbType.VarChar).Value = CNP;
                    using (var readerClient = commandClienti.ExecuteReader())
                    {
                        if (readerClient.HasRows)
                        {
                            readerClient.Read();
                            p = new Persoana();
                            p.Nume = readerClient["NUME"].ToString();
                            p.Prenume = readerClient["PRENUME"].ToString();
                            p.Email = readerClient["EMAIL"].ToString();
                            p.Cetatenie = readerClient["CETATENIE"].ToString();
                            p.DataNastere = (DateTime)readerClient["DATA_NASTERE"];
                            p.NumarPasaport = readerClient["NUMAR_PASAPORT"].ToString();
                            p.Telefon = readerClient["TELEFON"].ToString();
                            p.CNP = readerClient["CNP"].ToString();
                            p.Sex = readerClient["SEX"].ToString();
                            p.EsteClient = true;
                            return p;
                        }
                    }
                    SqlCommand rezCommand = new SqlCommand();
                    rezCommand.Connection = DBConnection;
                    rezCommand.CommandText = "SELECT * FROM REZERVANTI WHERE CNP=@cnp_cautat";
                    rezCommand.Parameters.Add("@cnp_cautat", SqlDbType.VarChar).Value = CNP;
                    using (var readerRezervant = rezCommand.ExecuteReader())
                    {
                        if (readerRezervant.HasRows == false)
                            return null;
                        else
                        {
                            readerRezervant.Read();
                            p = new Persoana();
                            p.Nume = readerRezervant["NUME"].ToString();
                            p.Prenume = readerRezervant["PRENUME"].ToString();
                            p.Email = readerRezervant["EMAIL"].ToString();
                            p.Cetatenie = readerRezervant["CETATENIE"].ToString();
                            p.DataNastere = (DateTime)readerRezervant["DATA_NASTERE"];
                            p.NumarPasaport = readerRezervant["NUMAR_PASAPORT"].ToString();
                            p.Telefon = readerRezervant["TELEFON"].ToString();
                            p.CNP = readerRezervant["CNP"].ToString();
                            p.Sex = readerRezervant["SEX"].ToString();
                            p.EsteClient = false;
                            return p;
                        }
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText(SQLExeptionsFile.FullName,
                        Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ex.Message,
                        Encoding.Unicode);
                    throw ex;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Eroare la citirea persoanei din baza de date",
                    "Baza de date nu a fost deschisa", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw new Exception("Baza de date nu a fost deschisa");
            }
        }
    }
}
