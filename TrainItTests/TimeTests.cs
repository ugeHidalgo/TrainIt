using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainItLibrary;

namespace TrainItTests
{
    [TestClass]
    public class TimeTests
    {
        [TestMethod]
        public void Time_TestCheckTimeFormat()
        {
            String aTimeString = "00:00:00";
            Time aTime = new Time();
            Boolean res = Time.CheckTimeFormat(aTimeString,99);
            Assert.AreEqual(true, res);

            aTimeString = "00:00:10";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(true, res);

            aTimeString = "00:00:59";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(true, res);

            aTimeString = "00:00:60";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(false, res);

            aTimeString = "00:01:00";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(true, res);

            aTimeString = "00:59:00";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(true, res);

            aTimeString = "00:60:00";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(false, res);

            aTimeString = "01:00:00";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(true, res);

            aTimeString = "60:00:00";
            res = Time.CheckTimeFormat(aTimeString, 99);
            Assert.AreEqual(true, res);

            aTimeString = "100:00:00";
            res = Time.CheckTimeFormat(aTimeString,100);
            Assert.AreEqual(true, res);

            aTimeString = "1000:00:00";
            res = Time.CheckTimeFormat(aTimeString,100);
            Assert.AreEqual(true, res);

            aTimeString = "1000:01:00";
            res = Time.CheckTimeFormat(aTimeString,1000);
            Assert.AreEqual(true, res);

            aTimeString = "1000:01:01";
            res = Time.CheckTimeFormat(aTimeString,1000);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Time_TestLoadTime()
        {
            String hours = "00";
            String minutes = "00";
            String seconds = "00";
            String aTimeString = hours + ":" + minutes + ":" + seconds;
            Time aTime = new Time();
            aTime = Time.ConvertStringToTime(aTimeString);
            Assert.AreEqual(hours, aTime.hours);
            Assert.AreEqual(minutes, aTime.minutes);
            Assert.AreEqual(seconds, aTime.seconds);

            hours = "01";
            minutes = "00";
            seconds = "00";
            aTimeString = hours + ":" + minutes + ":" + seconds;
            aTime = Time.ConvertStringToTime(aTimeString);
            Assert.AreEqual(hours, aTime.hours);
            Assert.AreEqual(minutes, aTime.minutes);
            Assert.AreEqual(seconds, aTime.seconds);

            hours = "03";
            minutes = "01";
            seconds = "03";
            aTimeString = hours + ":" + minutes + ":" + seconds;
            aTime = Time.ConvertStringToTime(aTimeString);
            Assert.AreEqual(hours, aTime.hours);
            Assert.AreEqual(minutes, aTime.minutes);
            Assert.AreEqual(seconds, aTime.seconds);

            hours = "300";
            minutes = "59";
            seconds = "59";
            aTimeString = hours + ":" + minutes + ":" + seconds;
            aTime = Time.ConvertStringToTime(aTimeString);
            Assert.AreEqual(hours, aTime.hours);
            Assert.AreEqual(minutes, aTime.minutes);
            Assert.AreEqual(seconds, aTime.seconds);
        }

        [TestMethod]
        public void Time_TestLoadString()
        {
            String hours = "00";
            String minutes = "00";
            String seconds = "00";
            String expectedTimeString = hours + ":" + minutes + ":" + seconds;
            Time aTime = new Time();
            aTime.hours = hours;
            aTime.minutes = minutes;
            aTime.seconds = seconds;
            String aTimeString = Time.ConvertTimeToString(aTime);
            Assert.AreEqual(expectedTimeString, aTimeString);

            hours = "01";
            minutes = "01";
            seconds = "01";
            expectedTimeString = hours + ":" + minutes + ":" + seconds;
            aTime.hours = hours;
            aTime.minutes = minutes;
            aTime.seconds = seconds;
            aTimeString = Time.ConvertTimeToString(aTime);
            Assert.AreEqual(expectedTimeString, aTimeString);

            hours = "10";
            minutes = "10";
            seconds = "10";
            expectedTimeString = hours + ":" + minutes + ":" + seconds;
            aTime.hours = hours;
            aTime.minutes = minutes;
            aTime.seconds = seconds;
            aTimeString = Time.ConvertTimeToString(aTime);
            Assert.AreEqual(expectedTimeString, aTimeString);

            hours = "100";
            minutes = "59";
            seconds = "59";
            expectedTimeString = hours + ":" + minutes + ":" + seconds;
            aTime.hours = hours;
            aTime.minutes = minutes;
            aTime.seconds = seconds;
            aTimeString = Time.ConvertTimeToString(aTime);
            Assert.AreEqual(expectedTimeString, aTimeString);
        }

        [TestMethod]
        public void Time_TestSumString()
        {
            String timeString1 = "00:00:00";
            String timeString2 = "00:00:00";
            String expectedSum = "00:00:00";
            Time time1 = new Time();
            Time time2 = new Time();
            Time timeES = new Time();
            time1 = Time.ConvertStringToTime(timeString1);                       
            time2 = Time.ConvertStringToTime(timeString2);
            timeES = Time.ConvertStringToTime(expectedSum);
            time1 = Time.TimeSum(time1,time2);
            Assert.AreEqual(timeES.hours,time1.hours);
            Assert.AreEqual(timeES.minutes, time1.minutes);
            Assert.AreEqual(timeES.seconds, time1.seconds);

            timeString1 = "00:00:59";
            timeString2 = "00:00:01";
            expectedSum = "00:01:00";
            time1 = Time.ConvertStringToTime(timeString1);
            time2 = Time.ConvertStringToTime(timeString2);
            timeES = Time.ConvertStringToTime(expectedSum);
            time1 = Time.TimeSum(time1, time2);
            Assert.AreEqual(timeES.hours, time1.hours);
            Assert.AreEqual(timeES.minutes, time1.minutes);
            Assert.AreEqual(timeES.seconds, time1.seconds);

            timeString1 = "00:59:59";
            timeString2 = "00:00:01";
            expectedSum = "01:00:00";
            time1 = Time.ConvertStringToTime(timeString1);
            time2 = Time.ConvertStringToTime(timeString2);
            timeES = Time.ConvertStringToTime(expectedSum);
            time1 = Time.TimeSum(time1, time2);
            Assert.AreEqual(timeES.hours, time1.hours);
            Assert.AreEqual(timeES.minutes, time1.minutes);
            Assert.AreEqual(timeES.seconds, time1.seconds);

            timeString1 = "99:48:59";
            timeString2 = "02:10:04";
            expectedSum = "101:59:03";
            time1 = Time.ConvertStringToTime(timeString1);
            time2 = Time.ConvertStringToTime(timeString2);
            timeES = Time.ConvertStringToTime(expectedSum);
            time1 = Time.TimeSum(time1, time2);
            Assert.AreEqual(timeES.hours, time1.hours);
            Assert.AreEqual(timeES.minutes, time1.minutes);
            Assert.AreEqual(timeES.seconds, time1.seconds);
        }

        [TestMethod]
        public void Time_ConvertToLong()
        {
            String hours = "00";
            String minutes = "00";
            String seconds = "00";
            long h = Convert.ToInt64(hours);
            long m = Convert.ToInt64(minutes);
            long s = Convert.ToInt64(seconds);
            long res = h * 60 * 60 + m * 60 + s;
            String aTimeString = hours + ":" + minutes + ":" + seconds;            
            Time time = new Time();            
            time = Time.ConvertStringToTime(aTimeString);
            long value = Time.ConvertTimeToLong(time);
            Assert.AreEqual(res,value);

            hours = "999999";
            minutes = "59";
            seconds = "59";
            h = Convert.ToInt64(hours);
            m = Convert.ToInt64(minutes);
            s = Convert.ToInt64(seconds);
            res = h * 60 * 60 + m * 60 + s;
            aTimeString = hours + ":" + minutes + ":" + seconds;            
            time = Time.ConvertStringToTime(aTimeString);
            value = Time.ConvertTimeToLong(time);
            Assert.AreEqual(res, value);  
        }

        [TestMethod]
        public void Time_ConvertToTime()
        {
            //Prepare values
            String hours = "0";
            String minutes = "00";
            String seconds = "00";
            long h = Convert.ToInt64(hours);
            long m = Convert.ToInt64(minutes);
            long s = Convert.ToInt64(seconds);
            long res = h * 60 * 60 + m * 60 + s;
            String aTimeString = hours + ":" + minutes + ":" + seconds;
            Time timeExpected = new Time();
            Time timeNew = new Time();

            //convert to long
            timeExpected = Time.ConvertStringToTime(aTimeString);
            long value = Time.ConvertTimeToLong(timeExpected);            
            Assert.AreEqual(res, value);
            
            //convert to time
            timeNew = Time.ConvertLongToTime(value);
            Assert.AreEqual(timeExpected.hours, timeNew.hours);
            Assert.AreEqual(timeExpected.minutes, timeNew.minutes);
            Assert.AreEqual(timeExpected.seconds, timeNew.seconds);

            //Prepare values
            hours = "999999";
            minutes = "59";
            seconds = "59";
            h = Convert.ToInt64(hours);
            m = Convert.ToInt64(minutes);
            s = Convert.ToInt64(seconds);
            res = h * 60 * 60 + m * 60 + s;
            aTimeString = hours + ":" + minutes + ":" + seconds;
            timeExpected = new Time();
            timeNew = new Time();

            //convert to long
            timeExpected = Time.ConvertStringToTime(aTimeString);
            value = Time.ConvertTimeToLong(timeExpected);
            Assert.AreEqual(res, value);

            //convert to time
            timeNew = Time.ConvertLongToTime(value);
            Assert.AreEqual(timeExpected.hours, timeNew.hours);
            Assert.AreEqual(timeExpected.minutes, timeNew.minutes);
            Assert.AreEqual(timeExpected.seconds, timeNew.seconds);
        }

    }
}
