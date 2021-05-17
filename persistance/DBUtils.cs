using System.Configuration;
using System.IO;
using System.Reflection;
using LinqToDB.Configuration;
using LinqToDB.Data;

namespace persistance
{
    public class ORMConnectionFactory
    {

        private static DataConnection instance = null;
        private static string connectionString = getConnectionString();
        
        public static DataConnection getConnection() {
            if (instance == null || instance.Connection.State == System.Data.ConnectionState.Closed)
                instance = createConnection();
            return instance;
        }

        private static string getConnectionString()
        {
            string returnValue = ConfigurationManager.ConnectionStrings["mainDB"].ConnectionString;
            string[] returns = returnValue.Split('=');
            string dbString = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location).Replace(@"\", "/");
            //string kstr = dbString.Replace("/FestivalServer", "");
            string kstr = dbString;
            dbString = returns[0] + "=" + kstr + "/" + returns[1];
            return dbString;
        }
        private static DataConnection createConnection()
        {
            var builder = new LinqToDbConnectionOptionsBuilder();
            builder.UseSQLite(connectionString);
            return new DataConnection(builder.Build());
        }

    }
}