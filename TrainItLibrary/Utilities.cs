using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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
   

        //Validates data into a textBox
        public static Boolean validateNotEmpty(object sender)
        {
            Boolean result = true;
            if (sender is TextBox)  
            {
                if (((TextBox)sender).Text == "")
                    result = false;
            }
            return result;
        }
    }
}
