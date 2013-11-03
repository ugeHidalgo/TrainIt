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

        //Calculate Speed
        public static string calculateSpeed(string aDist, string aTime)
        {
            string speedString = "Error";
            bool sigue=false;
            long time = 0;
            double dist = 0;
            try
            {
                time = Time.ConvertStringTimeToLong(aTime);
                dist = Convert.ToDouble(aDist);
                if (time == 0)
                    sigue = false;
                else sigue = true;
            }
            catch
            {
                sigue = false;
            }

            if (sigue)
            {
                decimal speed = Convert.ToDecimal(dist / time);                
                speed = speed * 60 * 60;
                speedString = String.Format("{0:0.00}", speed); 
            }

            return speedString;
        }
    }
}
