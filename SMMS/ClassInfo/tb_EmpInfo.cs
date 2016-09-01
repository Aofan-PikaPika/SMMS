using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMMS.ClassInfo
{
   public  class tb_EmpInfo
    {
        private string EmpId;
        public string intEmpId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }
        private string EmpName;
        public string strEmpName
        {
            get { return EmpName; }
            set { EmpName = value; }
        }
        private string EmpLoginName;
        public string strEmpLoginName
        {
            get { return EmpLoginName; }
            set { EmpLoginName = value; }
        }
        private string EmpLoginPwd;
        public string strEmpLoginPwd
        {
            set { EmpLoginPwd = value; }
            get { return EmpLoginPwd; }
        }
        private string EmpSex;
        public string strEmpSex
        {
            get { return EmpSex; }
            set { EmpSex = value; }
        }
        private string EmpDept;
        public string strEmpDept
        {
            set { EmpDept = value; }
            get { return EmpDept; }
        }
        private DateTime EmpBirthday;
        public DateTime daEmpBirthday
        {
            set { EmpBirthday = value; }
            get { return EmpBirthday; }
        }

        private string EmpPost;
        public string strEmpPost 
        {
            set { EmpPost = value; }
            get { return EmpPost; }
        }
        private string EmpPhone;
        public string strEmpPhone 
        {
            get { return EmpPhone; }
            set { EmpPhone = value; }
        }
        private string EmpAddress;
        public string strEmpAddress 
        {
            get { return EmpAddress; }
            set { EmpAddress = value; }
        }


        private int EmpFalg;
        public int intEmpFalg
        {
            set { EmpFalg = value; }
            get { return EmpFalg; }
        }
    }
}
