using System;
using System.Web;
using System.Data.SqlClient;

public class DbOperations
{
    private SqlConnection sqlconn;

    // Method for opening the connection to database.
    public string OpenConnection()
    {
       try
       {
            sqlconn = new SqlConnection();
            sqlconn.ConnectionString = "Data Source=USER-PC;Initial Catalog=collegedb;Integrated Security=True";
            sqlconn.Open();
           return null;
       }
       catch (Exception ex)
       {
           return ex.Message;
       }
   }

        // Method for closing the connection
        private bool CloseConnection()
        {
            try
            {
                sqlconn.Close();
                return true;
            }
            catch { return false; }
        }

 // Code showing how to insert record to database.
        public bool Insert(string name, string email, string message)
        {
            try
            {
                string query = "INSERT INTO feedback VALUES('" + name + "', '" + email + "', '" + message + "')";
                if (this.OpenConnection() == null)
                {
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    int res = cmd.ExecuteNonQuery();
                    if (res >= 1)
                        return true;
                }
            }
            finally
            {
                this.CloseConnection();
            }
            return false;
        }
}
