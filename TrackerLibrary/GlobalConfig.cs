using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
	{
        public static IDataConnection Connection { get; private set; }



		public static void InitializeConnections(DatabaseType connectionType)
		{
			if (connectionType == DatabaseType.Sql)
			{
				// TODO - SETUP THE SQL CONNECTOR PROPERLY
				SQLConnector sql = new SQLConnector();
				Connection = sql;
			}

			else if (connectionType == DatabaseType.TextFile)
			{
				// TODO - CREATE THE TEXT CONNECTION
				TextConnector text = new TextConnector();
				Connection = text;
			}

		}

		public static string ConnectionString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
    }
}
