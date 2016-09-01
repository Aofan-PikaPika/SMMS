using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMMS.ClassInfo
{
    class tb_ThGoodsInfo
    {
        private string KcID;
        public string intKcID
        {
            get { return KcID; }
            set { KcID = value; }
        }
        private string GoodsID;
        public string strGoodsID
        {
            get { return GoodsID; }
            set { GoodsID = value; }
        }
        private string SellID;
        public string strSellID
        {
            get { return SellID; }
            set { SellID = value; }
        }
        private string EmpId;
        public string strEmpId
        {
            set { EmpId = value; }
            get { return EmpId; }
        }



        private string ThGoodsName;
        public string strThGoodsName
        {
            get { return ThGoodsName; }
            set { ThGoodsName = value; }
        }

        private int ThGoodsNum;
        public int strThGoodsNum
        {
            get { return ThGoodsNum; }
            set { ThGoodsNum = value; }
        }


        private DateTime ThGoodsTime;
        public DateTime daThGoodsTime
        {
            set { ThGoodsTime = value; }
            get { return ThGoodsTime; }
        }

        private string ThGoodsPrice;
        public string deThGoodsPrice
        {
            set { ThGoodsPrice = value; }
            get { return ThGoodsPrice; }
        }
        private string ThNeedPay;
        public string deThNeedPay
        {
            get { return ThNeedPay; }
            set { ThNeedPay = value; }
        }
        private string ThHasPay;
        public string deThHasPay
        {
            get { return ThHasPay; }
            set { ThHasPay = value; }
        }

        private string ThGoodsResult;
        public string deThGoodsResult
        {
            get { return ThGoodsResult; }
            set { ThGoodsResult = value; }
        }

    }
}
