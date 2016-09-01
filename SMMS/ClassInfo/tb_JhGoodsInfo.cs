using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMMS.ClassInfo
{
    public class tb_JhGoodsInfo
    {
        private string EmpId;
        public string strEmpId
        {
            get { return EmpId; }
            set { EmpId = value; }
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
        private string DepotName;
        public string strDepotName
        {
            set { DepotName = value; }
            get { return DepotName; }
        }



        private string GoodsName;
        public string strGoodsName
        {
            get { return GoodsName; }
            set {GoodsName = value; }
        }

        private int GoodsNum;
        public int strGoodsNum 
        {
            get { return GoodsNum; }
            set { GoodsNum = value; }
        }


        private string GoodsUnit;
        public string strGoodsUnit
        {
            set { GoodsUnit = value; }
            get { return GoodsUnit; }
        }
        private DateTime GoodTime;
        public DateTime daGoodTime
        {
            set { GoodTime = value; }
            get { return GoodTime; }
        }

        private string GoodsJhPrice;
        public string deGoodsJhPrice
        {
            set { GoodsJhPrice = value; }
            get { return GoodsJhPrice; }
        }
        private string GoodsSellPrice;
        public string deGoodsSellPrice
        {
            get { return GoodsSellPrice; }
            set { GoodsSellPrice = value; }
        }
        private string GoodsNeedPrice;
        public string deGoodsNeedPrice
        {
            get { return GoodsNeedPrice; }
            set { GoodsNeedPrice = value; }
        }

        private string GoodsNoPrice;
        public string deGoodsNoPrice 
        {
            get { return GoodsNoPrice; }
            set { GoodsNoPrice = value; }
        }

        private string GoodsRemark;
        public string strGoodsRemark 
        {
            get { return GoodsRemark; }
            set { GoodsRemark = value; }
        }


        private int EmpFalg;
        public int Falg
        {
            set { EmpFalg = value; }
            get { return EmpFalg; }
        }
    }
}
