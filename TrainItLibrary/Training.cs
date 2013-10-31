﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainItLibrary
{
    public class Training
    {
        private static Int64 trainID;
        private static string trainName;
        private static DateTime trainDate;
        private static Int64 userID;

        public Int64 TrainID
        {
            get { return trainID; }
            set { trainID = value; }

        }
        public string TrainName
        {
            get { return trainName; }
            set { trainName = value; }

        }
        public DateTime TrainDate
        {
            get { return trainDate; }
            set { trainDate = value; }

        }
        public Int64 UserID
        {
            get { return userID; }
            set { userID = value; }

        }

        public Training()
        {
            trainID = -1;
            trainName = "No name";
            trainDate = DateTime.Now;
            userID=-1;
        }

        public Training(Int64 TrainID, string TrainName, DateTime TrainDate, Int64 UserID)
        {
            trainID=TrainID;
            trainName=TrainName;
            trainDate=TrainDate;
            userID=UserID;
        }

        public Training Reset()
        {
            Training aTraining = new Training();
            return aTraining;
        }

        public Training LoadDataFromView(string txtID, string txtName, DateTime dtpDate, string txtUserID)
        {
            Training aT = new Training();
            bool sigue = true;
            try
            {
                trainID = Convert.ToInt64(txtID);
            }
            catch (Exception)
            {
                sigue = false;
            }

            if (sigue)
            {
                try
                {
                    userID = Convert.ToInt64(txtUserID);
                }
                catch (Exception)
                {
                    sigue = false;
                }   
            }

            if (sigue)
            {
                trainName = txtName;
                trainDate = dtpDate;
            }
            else
                aT = aT.Reset();

            return aT;
        }

    }
}
