using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateChekcIn;
        private DateTime? dateChekcOut;
        private int status;
        private int discount;

        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.ID = iD;
            this.DateChekcIn = dateChekcIn;
            this.DateChekcOut = dateChekcOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateChekcIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTemp = row["dateCheckOut"];

            if(dateCheckOutTemp.ToString() != "")
                this.DateChekcOut = (DateTime?)dateCheckOutTemp;
            
            this.Status = (int)row["status"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateChekcIn { get => dateChekcIn; set => dateChekcIn = value; }
        public DateTime? DateChekcOut { get => dateChekcOut; set => dateChekcOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
