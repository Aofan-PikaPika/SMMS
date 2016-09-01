using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMMS.ClassInfo;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SMMS.GoodMethod
{
   public  class tb_CompanyMethod
    {
       SqlConnection conn = null;
       SqlCommand cmd = null;
       SqlDataReader sqlreader = null;
       #region 添加
       public int tb_CompamyMethodAdd(tb_Company Commany) 
       {
           int intFlag = 0;
           try
           {
               string str_Add = "insert into tb_Company values(";
               str_Add += "'" + Commany.intCompanyID + "','" + Commany.strCompanyName + "','" + Commany.strCompanyDirector + "','";
               str_Add += "'" + Commany.strCompanyPhone + "','" + Commany.strCompanyAddress + "','";
               str_Add += "'" + Commany.strCompanyRemark + "','" + Commany.daReDateTime + "','" + Commany.intFalg + "')";
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(str_Add,conn);
               intFlag = cmd.ExecuteNonQuery();
               conn.Dispose();
               return intFlag;
           }
           catch (Exception ex) 
           {
               MessageBox.Show(ex.ToString());
               return intFlag;
           }

       }
       #endregion

       #region 修改
       public int tb_CompanyMethodUpdate(tb_Company Company) 
       {
           int intFlag = 0;
           try 
           {
               string str_Add = "update tb_Company set ";
               str_Add += "CompanyName='" + Company.strCompanyName + "',CompanyDirector='" + Company.strCompanyDirector + "',";
               str_Add+="CompanyPhone='"+Company.strCompanyPhone+"',CompanyAddress='"+Company.strCompanyAddress+"',CompanyRemark='"+Company.strCompanyRemark+"',";
               str_Add += "ReDataTime='" + Company.daReDateTime + "',Falg='" + Company.intFalg + "'where CompanyID='" + Company.intCompanyID + "'";
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(str_Add,conn);
               conn.Dispose();
               return intFlag;
           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.ToString());
                   return intFlag;
           }
       }
        #endregion

       #region 删除
       public int tb_CompanyMethodDelete(tb_Company Company) 
       {
           int intFlag = 0;
           try
           {
               string str_Add = "update tb_Company set";
               str_Add += "Falg='" + Company.intFalg + "'where CompanyID='" + Company.intCompanyID + "'";
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(str_Add,conn);
               intFlag = cmd.ExecuteNonQuery();
               conn.Dispose();
               return intFlag;



           }
           catch (Exception ex) 
           {
               MessageBox.Show(ex.ToString());
                return intFlag;
           }
       }
        #endregion 

        #region 查询

       public void tb_CompanyFind(string strObject,int intFlag,object DataObject) 
       {
           
           string strSecar = null;
           try 
           {
               switch (intFlag) 
               {
                   case 1:
                       strSecar = "select*from tb_Company where CompanyName like'%"+strObject+"%'and Falg=0";
                       break;
                   case 2:
                       strSecar = "select*from tb_Company where CompanyDirector like'%" + strObject + "%'and Falg=0";
                       break;
                   case 3:
                       strSecar = "select*from tb_Company where Falg=0";
                       break;
               }
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(strSecar,conn);
               int i = 0;
               sqlreader = cmd.ExecuteReader();
               while(sqlreader.Read())
               {
                   i++;
               }
               sqlreader.Close();
               System.Windows.Forms.DataGridView dv = (DataGridView)DataObject;
               if (i != 0)
               {
                   int n = 0;
                   dv.RowCount = i;
                   sqlreader = cmd.ExecuteReader();
                   while (sqlreader.Read())
                   {
                       dv[0, n].Value = sqlreader[0].ToString();
                       dv[1, n].Value = sqlreader[1].ToString();
                       dv[2, n].Value = sqlreader[2].ToString();
                       dv[3, n].Value = sqlreader[3].ToString();
                       dv[4, n].Value = sqlreader[4].ToString();
                       n++;
                   }
                   sqlreader.Close();

               }
               else 
               {
                   for (int x = 0; i < dv.RowCount;x++ )
                   {
                       dv[0, x].Value = "";
                       dv[1, x].Value = "";
                       dv[2, x].Value = "";
                       dv[3, x].Value = "";
                       dv[4, x].Value = "";


                   }
               }
      
           }
           catch (Exception ex) 
           {
               MessageBox.Show(ex.ToString());
           }

       }
       public SqlDataReader tb_CompanyFind(string strObject) 
       {
           string strSecar = null;
           try 
           {
               strSecar = "select*from tb_Company where CompanyID='"+strObject+"'and Falg=0";
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(strSecar,conn);
               sqlreader = cmd.ExecuteReader();
               return sqlreader;

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
               return sqlreader;
           }
       }






        #endregion

        #region 生成客户编号

       public string tb_CustomerID() 
       {
           int intYear = DateTime.Now.Year;
           int intMonth = DateTime.Now.Month;
           int intDay = DateTime.Now.Year;
           string strTime = null;
           strTime = intYear.ToString();
           if (intMonth < 10)
           {
               strTime += "0" + intMonth.ToString();
           }
           else 
           {
               strTime += intMonth.ToString();
           }
           if (intDay < 10)
           {
               strTime += "0" + intDay.ToString();

           }
           else 
           {
               strTime += intDay.ToString();
           }
           return("KN-"+strTime);



       }

        #endregion 

        #region  treeview空间 填充商品类别

       public void filltProd(object objTreeView,object obimage) 
       {
           try 
           {
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               string strSecar = "select *from tb_Company where Falg=0";
               cmd = new SqlCommand(strSecar,conn);
               sqlreader = cmd.ExecuteReader();
               if(objTreeView.GetType().ToString()== "System.Windows.Forms.TreeView")
               {
                   System.Windows.Forms.ImageList imlist=(System.Windows.Forms.ImageList)obimage;
                   System.Windows.Forms.TreeView TV=(System.Windows.Forms.TreeView)objTreeView;
                   TV.ImageList=imlist;
                   TV.Nodes.Clear();
                   System.Windows.Forms.TreeNode TN=new System.Windows.Forms.TreeNode("供应商名称",0,1);
                   while(sqlreader.Read())
                   {
                       TN.Nodes.Add("",sqlreader[1].ToString(),0,1);

                   }
                   TV.Nodes.Add(TN);
                   sqlreader.Close();
                   TV.ExpandAll();
               }

           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.ToString());

           }

       }
   





        #endregion

    
    }
}
