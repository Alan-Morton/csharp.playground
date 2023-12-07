using System;
using Microsoft.Data.SqlClient;
using Push.Libraries.Data;

namespace Push.DataAccess.Analytics
{
    public class TestAccess : ADORepository
    {
        public bool CheckDbConnection()
        {
            try
            {
                string dbContext = "Data Source=desktop-r72jr3k;Initial Catalog=live-dev-202203;user id=sa;password=LaSQhzpA3MfzFF6WHmGk!h;TrustServerCertificate=True";// "Data Source=desktop-r72jr3k;Initial Catalog=data-analytics-3;user id=sa;password=LaSQhzpA3MfzFF6WHmGk!h"; // Environment.GetEnvironmentVariable("dbContext");
                SqlConnection connection = new SqlConnection(dbContext);
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
