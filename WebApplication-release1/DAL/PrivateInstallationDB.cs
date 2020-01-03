using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class PrivateInstallationDB
    {
        public void AddLage(string Strasse, string Nr, string PLZ, string Stadt)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NEE_DB"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                  

                    string query = "Insert into [Private Installation] ( Strasse, Nr, PLZ, Stadt) " +
                        " VALUES(" + Strasse + ", " + Nr + ", " + PLZ + ", " + Stadt + ")";

                    SqlCommand cmd = new SqlCommand(query, cn);


                    cn.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
