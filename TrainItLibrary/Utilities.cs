using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TrainItLibrary
{
    public class Utilities
    {
        //Retrieve the conn string.
        public static string GetConnString()
        {
            string value = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["TrainIt.Properties.Settings.TrainITConnectionString"];
            if (settings != null)
                value = settings.ConnectionString;
            return value;
        }        
    }
}
