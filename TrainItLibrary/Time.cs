using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainItLibrary
{
    public class Time
    {
        public string hours;
        public string minutes;
        public string seconds;      

        public Time()
        {
            hours = "00";
            minutes = "00";
            seconds = "00";
        }

        public static Boolean CheckTimeFormat(string aString)
        {//Verify if string passed is a correct time format: hh:mm:00
         //hh tiene que ser >=0.
         //mm tiene que ser >=0 y <60
         //ss tiene que ser >=0 y <60            
            Boolean result = true;

            //Verify if both : exists
            int first = aString.IndexOf(":");
            int second = aString.LastIndexOf(":");
            if ((first == -1) || (second == -1))                            
                result = false;                            

            if (result)
            {
                string hoursPart = aString.Substring(0, first);
                string minutesPart = aString.Substring(first+1, second-hoursPart.Length-1);
                string secondsPart = aString.Substring(second+1, aString.Length-hoursPart.Length-1-minutesPart.Length-1);

                try
                {
                    int hours = Convert.ToInt16(hoursPart);
                    result = true;
                }
                catch (Exception)
                {
                    result = false;                    
                }

                if (result)
                {
                    try
                    {
                        int minutes = Convert.ToInt16(minutesPart);
                        if ((minutes >= 0) && (minutes < 60))
                            result = true;
                        else
                            result = false;
                    }
                    catch (Exception)
                    {
                        result = false;                    
                    }
                }

                if (result)
                {
                    try
                    {
                        int seconds = Convert.ToInt16(secondsPart);
                        if ((seconds >= 0) && (seconds < 60))
                            result = true;
                        else
                            result = false;
                    }
                    catch (Exception)
                    {
                        result = false;
                    }
                }


                if (result)
                {
                    string aTime = hoursPart + ":" + minutesPart + ":" + secondsPart;
                }
            }
            return result;
        }

        public static Time ConvertStringToTime(string aString)
        {//Convert a string to format hh:mm:ss. If error return an exception error.
            Boolean result = true;
            Time aTime = new Time();

            //Verify if both : exists
            Exception aExceptMissingTimeSep = new Exception("Missing time separators ':'");
            Exception aExceptBadHour = new Exception("Bad hour entry");
            Exception aExceptBadMinute = new Exception("Bad minute entry");
            Exception aExceptBadSecond = new Exception("Bad second entry");
            int first = aString.IndexOf(":");
            int second = aString.LastIndexOf(":");
            if ((first == -1) || (second == -1))
            {
                result = false;
                throw (aExceptMissingTimeSep);
            }

            if (result)
            {
                string hoursPart = aString.Substring(0, first);
                string minutesPart = aString.Substring(first + 1, second - hoursPart.Length - 1);
                string secondsPart = aString.Substring(second + 1, aString.Length - hoursPart.Length - 1 - minutesPart.Length - 1);

                try
                {
                    long hours = Convert.ToInt64(hoursPart);
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                    throw(aExceptBadHour);
                }

                if (result)
                {
                    try
                    {
                        int minutes = Convert.ToInt16(minutesPart);
                        if ((minutes >= 0) && (minutes < 60))
                            result = true;
                        else
                            result = false;
                    }
                    catch (Exception)
                    {
                        result = false;
                        throw(aExceptBadMinute);
                    }
                }

                if (result)
                {
                    try
                    {
                        int seconds = Convert.ToInt16(secondsPart);
                        if ((seconds >= 0) && (seconds < 60))
                            result = true;
                        else
                            result = false;
                    }
                    catch (Exception)
                    {
                        result = false;
                        throw (aExceptBadSecond);
                    }
                }


                if (result)
                {
                    aTime.hours = hoursPart;
                    aTime.minutes =minutesPart;
                    aTime.seconds =secondsPart;
                }
            }
            return aTime;
        }

        public static string ConvertTimeToString(Time aTime)
        {

            string result = aTime.hours + ":" + aTime.minutes + ":" + aTime.seconds;
            return result;
        }

        public static Time TimeSum(Time time1, Time time2)
        {//return the sum of time1 and time2
            Time result = new Time();
            int sec1 = Convert.ToInt16(time1.seconds);
            int sec2 = Convert.ToInt16(time2.seconds);
            int min1 = Convert.ToInt16(time1.minutes);
            int min2 = Convert.ToInt16(time2.minutes);
            int h1 = Convert.ToInt16(time1.hours);
            int h2 = Convert.ToInt16(time2.hours);

            //Sum the seconds
            int sumSec = sec1 + sec2;
            int resMin = 0;
            if (sumSec>59)  
            {
                sumSec = sumSec - 60;          
                resMin = 1;
            }

            //Sum the minutes
            int sumMin = min1 + min2 + resMin;
            int resH=0;
            if (sumMin > 59)
            {
                sumMin = sumMin - 60;
                resH = 1;
            }
            
            //Sum the hours 
            int sumH = h1 + h2 + resH;

            //Pass the seconds to string and add a 0 to the right is length=1;
            string aux = sumSec.ToString();
            if (aux.Length == 1)
            {
                aux = "0" + aux;
            }
            result.seconds = aux;

            //Pass the minutes to string and add a 0 to the right is length=1;
            aux = sumMin.ToString();
            if (aux.Length == 1)
            {
                aux = "0" + aux;
            }
            result.minutes = aux;

            //Pass the hours to string and add a 0 to the right is length=1;
            aux = sumH.ToString();
            if (aux.Length == 1)
            {
                aux = "0" + aux;
            }
            result.hours = aux;

            return result;
        }

        public static long ConvertTimeToLong(Time aTime)
        {
            long h = Convert.ToInt64(aTime.hours);
            long m = Convert.ToInt64(aTime.minutes);
            long s = Convert.ToInt64(aTime.seconds);
            long res = h * 60 * 60 + m * 60 + s;
            return res;
        }

        public static Time ConvertLongToTime(long value)
        {
            long h = value / 3600;
            long hMod = value % 3600;
            long m = hMod / 60;
            long s = hMod % 60;

            Time aTime = new Time();
            aTime.hours = h.ToString();
            aTime.minutes = m.ToString();
            if (aTime.minutes.Length == 1)
                aTime.minutes = "0" + aTime.minutes;
            aTime.seconds = m.ToString();
            if (aTime.seconds.Length == 1)
                aTime.seconds = "0" + aTime.seconds;

            return aTime;
        }

        public static long ConvertStringTimeToLong(string aString)
        {
            long result;
            Time aTime=new Time();

            aTime = ConvertStringToTime(aString);
            result = ConvertTimeToLong(aTime);

            return result;
        }

        public static string ConvertLongToStringTime(long aLong)
        {
            string result = "";
            Time aTime = new Time();

            aTime = ConvertLongToTime(aLong);
            result = ConvertTimeToString(aTime);

            return result;
        }
    }
}
