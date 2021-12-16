using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace UseSQLServer
{
    class AdapterSQLServer
    {
        protected static string ConnectionString =
            ConfigurationManager.ConnectionStrings["UseSQLServer.Properties.Settings.MyeStoreConnectionString"]
            .ConnectionString.ToString();
    }
}
