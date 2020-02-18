using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.DataContext
{
    public class BaseDataContext : IDisposable
    {
        private string ConnectionString => Settings.AppConfiguration.GetConnectionString();
        protected MySql.Data.MySqlClient.MySqlConnection Connection;

        public BaseDataContext()
        {
            Connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
            Connection.Dispose();
        }
    }
}
