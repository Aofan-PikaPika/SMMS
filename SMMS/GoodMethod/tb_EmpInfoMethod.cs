using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SMMS.ClassInfo;
using System.Windows.Forms;

using System.Data;
using SMMS.GoodMethod;


namespace SMMS.GoodMethod
{
    public class tb_EmpInfoMethod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader sqlreader = null;
        #region 登录验证查询


        public int tb_EmpInfoFind(string strObject, string pwd, int intFalg) 
        {
            int intCount = 0;
            string strSecar = null;
            try 
            {
                switch (intFalg) 
                {
                    case 1:
                        strSecar = "select * from tb_EmpInfo where EmpLoginName='" + strObject + "'and EmpFalg=0";
                        break;
                    case 2:
                        strSecar = "select * from tb_EmpInfo where EmpLoginName='" + strObject + "'and EmpFalg=0  and EmpLoginPwd='" + pwd + "'";
                        break;
                }
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar,conn);
                sqlreader = cmd.ExecuteReader();
                sqlreader.Read();
                if(sqlreader.HasRows)
                {
                    intCount = 1;
                }
                return intCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return intCount = 2;
            }
        }


        #endregion


        #region 创建导航栏
        private DataTable GetDataTable(string strCode,string strTableName) 
        {
            DataTable dt = null;
            SqlDataAdapter sda = null;
            getSqlConnection getConnection=new getSqlConnection();
            conn=getConnection.GetCon();
            try 
            {
                sda = new SqlDataAdapter(strCode, conn);
                dt = new DataTable(strTableName);
                sda.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;

            }
            return dt;
        }







        public void BuildTree(TreeView tv,ImageList imglist,string strTableName) 
        {
            string strSql = null;
            TreeNode rootNode1 = null;
            TreeNode childNode = null;
            string Dept=null;
            strSql = "select*from tb_EmpInfo";
            tv.Nodes.Clear();
            tv.ImageList = imglist;
            rootNode1 = new TreeNode();
            rootNode1.Tag = null;
            rootNode1.Text ="技术部";
            rootNode1.ImageIndex = 0;

            TreeNode rootNode2 = null;
            rootNode2 = new TreeNode();
            rootNode2.Text = "行政部";
            rootNode2.ImageIndex = 0;

            TreeNode rootNode3 = null;
            rootNode3 = new TreeNode();
            rootNode3.Text = "市场部";
            rootNode3.ImageIndex = 0;

            TreeNode rootNode4 = null;
            rootNode4 = new TreeNode();
            rootNode4.Text = "财务部";
            rootNode4.ImageIndex = 0;
            try
            {
                DataTable dt = GetDataTable(strSql,strTableName);
                foreach(DataRow row in dt.Rows)
                {
                    childNode = new TreeNode();
                    childNode.Tag=row["EmpId"];
                    childNode.Text = row["EmpLoginName"].ToString();
                    childNode.ImageIndex = 1;
                    Dept=row["EmpDept"].ToString();
                    switch(Dept)
                    {
                        case "技术部": 
                            { rootNode1.Nodes.Add(childNode);
                              
                              childNode.SelectedImageIndex = 4;
                            }
                            break;
                        case "行政部":
                            {
                                rootNode2.Nodes.Add(childNode);
                                childNode.SelectedImageIndex = 3;
                            } 
                            break;
                        case "市场部":
                            {
                                rootNode3.Nodes.Add(childNode);
                                childNode.SelectedImageIndex = 1;
                            } break;
                        case "财务部":
                            { rootNode4.Nodes.Add(childNode);
                            childNode.SelectedImageIndex = 2;
                        }
                            break;

                    }
                   

                }
                tv.Nodes.Add(rootNode1);
                tv.Nodes.Add(rootNode2);
                tv.Nodes.Add(rootNode3);
                tv.Nodes.Add(rootNode4);
                tv.ExpandAll();
                
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message,"erro");
                throw e;
            }


        }




        #endregion
        #region 填充信息


        public DataTable FillEmp(string strWhere,string strTableName) 
        {
            string strSql = null;
            strSql = "select * from tb_EmpInfo where EmpId='" + strWhere + "'";
            try 
            {
                DataTable dt = GetDataTable(strSql,strTableName);
                return dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"erro");
                throw ex;
            }
        }









        #endregion

        #region 更改信息
        public int tb_EmpInfoMethodUpdate(tb_EmpInfo tbemp) 

        {
            int intFalg = 0;
            try 
            {
                string strUpdate = "update tb_EmpInfo set ";
                strUpdate += "EmpName='" + tbemp.strEmpName + "',EmpLoginName='" + tbemp.strEmpLoginName + "',EmpLoginPwd='"+tbemp.strEmpLoginPwd+"',";
                strUpdate += "EmpSex='" + tbemp.strEmpSex + "',EmpBirthday='" + tbemp.daEmpBirthday + "',EmpDept='" + tbemp.strEmpDept + "',EmpPost='"+tbemp.strEmpPost+"',";
                strUpdate += "EmpPhone='" + tbemp.strEmpPhone + "',EmpAddress='" + tbemp.strEmpAddress + "'where EmpId='" + tbemp.intEmpId + "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strUpdate, conn);
                intFalg = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFalg;
            
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return intFalg;
            }



        }
        #endregion

        #region 图片保存到数据库

        public int picSql(Byte[] bt,tb_EmpInfo tbemp)
        {
            int flag = 0;

            try
            {
                string picsql = "update tb_EmpInfo set ";
                picsql += "EmpImag=@images where  EmpId='" + tbemp.intEmpId + "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(picsql, conn);
                cmd.Parameters.Add("@images", SqlDbType.Image).Value = bt;
                flag = cmd.ExecuteNonQuery();
                conn.Dispose();
                return flag;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return flag;
            }
            
        }




        #endregion 

        #region 从数据库中提取图片

        public Byte[] ShowPic(string strWhere) 
        {

            string showStr = "select EmpImag from tb_EmpInfo where EmpId='"+strWhere+"'";
            getSqlConnection getConnection = new getSqlConnection();
            conn = getConnection.GetCon();
            cmd = new SqlCommand(showStr, conn);
            SqlDataReader picreader = cmd.ExecuteReader();
            picreader.Read();
            Byte[] br = (Byte[])picreader["EmpImag"];
            conn.Dispose();
            return br;
        }



        #endregion







    }
}
