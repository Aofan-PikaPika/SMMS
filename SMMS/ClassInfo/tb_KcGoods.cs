using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMMS.ClassInfo
{
    class tb_KcGoods
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
        private string JhCompName;
        public string strJhCompName
        {
            get { return JhCompName; }
            set { JhCompName = value; }
        }
        private string KcDeptName;
        public string strKcDeptName
        {
            set { KcDeptName = value; }
            get { return KcDeptName; }
        }



        private string KcGoodsName;
        public string strKcGoodsName
        {
            get { return KcGoodsName; }
            set { KcGoodsName = value; }
        }

        private int KcNum;
        public int intKcNum
        {
            get { return KcNum; }
            set { KcNum = value; }
        }
        private int KcAlarmNum;
        public int intKcAlarmNum 
        {
            get { return KcAlarmNum; }
            set { KcAlarmNum = value; }
        }






        private string KcUnit;
        public string strKcUnit
        {
            set { KcUnit = value; }
            get { return KcUnit; }
        }
        private DateTime KcTime;
        public DateTime daKcTime
        {
            set { KcTime = value; }
            get { return KcTime; }
        }

        private string KcGoodsPrice;
        public string deKcGoodsPrice
        {
            set { KcGoodsPrice = value; }
            get { return KcGoodsPrice; }
        }
        private string KcSellPrice;
        public string deKcSellPrice
        {
            get { return KcSellPrice; }
            set { KcSellPrice = value; }
        }
        private string KcEmp;
        public string strKcEmp
        {
            get { return KcEmp; }
            set { KcEmp = value; }
        }

        private string KcRemark;
        public string strKcRemark
        {
            get { return KcRemark; }
            set { KcRemark = value; }
        }
      
    }
}
