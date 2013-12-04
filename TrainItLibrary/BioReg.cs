using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainItLibrary
{
    public class BioReg
    {
        private Int64 BioRegID;
        private Int64 BioRegTypeID;
        private DateTime BioRegDate;
        private Double Value;
        private String Memo;
        private Int64 UserID;

        public Int64 bioRegID
        {
            get { return BioRegID; }
            set { BioRegID = value; }
        }
        public Int64 bioRegTypeID
        {
            get { return BioRegTypeID; }
            set { BioRegTypeID = value; }
        }
        public DateTime bioRegDate
        {
            get { return BioRegDate; }
            set { BioRegDate = value; }
        }
        public Double value
        {
            get { return Value; }
            set { Value = value; }
        }
        public String memo
        {
            get { return Memo; }
            set { Memo = value; }
        }
        public Int64 userID
        {
            get { return UserID; }
            set { UserID = value; }
        }

        public BioReg()
        {
            BioRegID = -1;
            BioRegTypeID = -1;
            BioRegDate = DateTime.Now;
            Value = 0;
            Memo = "";
            UserID = -1;
        }

        public void Clear()
        {
            BioRegID = -1;
            BioRegTypeID = -1;
            BioRegDate = DateTime.Now;
            Value = 0;
            Memo = "";
            UserID = -1;
        }
    }
}
