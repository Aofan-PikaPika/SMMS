using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMMS.ClassInfo
{
    class tb_SellGoods
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



        private string GoodsName;
        public string strGoodsName
        {
            get { return GoodsName; }
            set { GoodsName = value; }
        }

        private int SellGoodsNum;
        public int strSellGoodsNum
        {
            get { return SellGoodsNum; }
            set { SellGoodsNum = value; }
        }


        private DateTime SellGoodsTime;
        public DateTime daSellGoodsTime
        {
            set { SellGoodsTime = value; }
            get { return SellGoodsTime; }
        }

        private string SellPrice;
        public string deSellPrice
        {
            set { SellPrice = value; }
            get { return SellPrice; }
        }
        private string SellNeedPay;
        public string deSellNeedPay
        {
            get { return SellNeedPay; }
            set { SellNeedPay = value; }
        }
        private string SellHasPay;
        public string deSellHasPay
        {
            get { return SellHasPay; }
            set { SellHasPay = value; }
        }

        private string SellRemark;
        public string strSellRemark
        {
            get { return SellRemark; }
            set { SellRemark = value; }
        }

        private int SellFalg;
        public int intSellFalg 
        {
            get { return SellFalg; }
            set { SellFalg = value; }
        }
    }
}
