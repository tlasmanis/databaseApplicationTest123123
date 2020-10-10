using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseApplication
{
    class Connector
    {
        private string dataSource;
        private string initialCatalog;
        private string userID;
        private string password;
        private string connectionString;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dR;
        private SqlDataAdapter dA;
        private SqlCommandBuilder cB;
    }
}
