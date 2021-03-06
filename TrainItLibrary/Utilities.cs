﻿using System;
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

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings
                ["TrainIt.Properties.Settings.TrainITConnectionString"];
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
            string speedString = "0.0";
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

        //Calculate Pace
        public static string calculatePace(string aDist, string aTime, string aPaceDist)
        {
            string pace = "00:00:00";
            bool sigue = false;
            double time = 0;
            double dist = 0;
            double paceDist = 0;

            try
            {
                time = (double)(Time.ConvertStringTimeToLong(aTime));
                dist = Convert.ToDouble(aDist);
                paceDist = Convert.ToDouble(aPaceDist);
                sigue = true;
            }
            catch 
            {
                sigue = false;                
            }

            if (sigue)
            {
                long paceResult=0;
                if (dist == 0)
                    paceResult = 0;
                else 
                    paceResult = (long)( (time * paceDist) / dist);

                pace = Time.ConvertLongToStringTime(paceResult);
            }

            return pace;
        }                            

        //Calculates first day of year
        public static DateTime firstDayOfYear(DateTime dateTime)
        {
            DateTime result;
            result = dateTime.AddDays(-(dateTime.Day - 1));
            result = result.AddMonths(-(dateTime.Month - 1));
            return result;
        }

        //Calculates last day of year
        public static DateTime lastDayOfYear(DateTime dateTime)
        {
            DateTime result;
            result = dateTime.AddYears(1);
            result = result.AddMonths(-(dateTime.Month-1));
            result = result.AddDays(-(dateTime.Day));
            return result;
        }

        //Calculates first day of month
        public static DateTime firstDayOfMonth(DateTime dateTime)
        {
            DateTime result;
            result=dateTime.AddDays(-(dateTime.Day-1));
            return result;
        }

        //Calculates last day of month
        public static DateTime lastDayOfMonth(DateTime dateTime)
        {
            DateTime result;
            result = dateTime.AddMonths(1);
            result = result.AddDays(-(dateTime.Day));            
            return result;
        }

        //Calculates first day of week
        public static DateTime firstDayOfWeek(DateTime dateTime)
        {
            DateTime result;
            result = dateTime.AddDays(-(Convert.ToInt32(dateTime.DayOfWeek)-1));
            return result;
        }

        //Calculates last day of week
        public static DateTime lastDayOfWeek(DateTime dateTime)
        {
            DateTime result;
            result = dateTime.AddDays((7-Convert.ToInt32(dateTime.DayOfWeek)));
            return result;
        }
    }
}
