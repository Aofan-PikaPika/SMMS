using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMMS.ClassInfo
{
    public class tb_Company
    {
        private string CompanyID;
        public string intCompanyID
        {
            get{return CompanyID;}
            set{CompanyID=value;}
        }
        private string CompanyName;
        public string strCompanyName 
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }
        private string CompanyDirector;
        public string strCompanyDirector 
        {
            get { return CompanyDirector; }
            set { CompanyDirector = value; }
        }
        private string CompanyPhone;
        public string strCompanyPhone 
        {
            set { CompanyPhone = value; }
            get { return CompanyPhone; }
        }
        private string CompanyAddress;
        public string strCompanyAddress 
        {
            get { return CompanyAddress; }
            set { CompanyAddress = value; }
        }
        private string CompanyRemark;
        public string strCompanyRemark 
        {
            set { CompanyRemark = value; }
            get { return CompanyRemark; }
        }
        private DateTime ReDateTime;
        public DateTime daReDateTime 
        {
            set { ReDateTime = value; }
            get { return ReDateTime; }
        }
        private int Falg;
        public int intFalg 
        {
            set { Falg = value; }
            get { return Falg; }
        }


    }
}
