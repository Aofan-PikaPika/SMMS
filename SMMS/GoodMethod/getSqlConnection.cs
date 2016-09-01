using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SMMS.GoodMethod
{
   public  class getSqlConnection
    {
       string strConnectionString = "server=(local)\\SQLEXPRESS;database=db_CSManage;uid=sa;pwd=123456";
       SqlConnection sqlcon;
       public getSqlConnection() { }
       public SqlConnection GetCon() 
       {
           sqlcon = new SqlConnection(strConnectionString);
           sqlcon.Open();
           return sqlcon;
       }

    }
}
