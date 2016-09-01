using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using SMMS.GoodMethod;
using SMMS.ClassInfo;
using System.IO;
namespace SMMS
{
    public partial class frmEmpInfo : Skin_Mac
    {
        public frmEmpInfo()
        {
            InitializeComponent();
        }

        tb_EmpInfoMethod emp = new tb_EmpInfoMethod();
        tb_EmpInfo tbemp = new tb_EmpInfo();
        Byte[] imgByteIn = null;
        private void frmEmpInfo_Load(object sender, EventArgs e)
        {

            emp.BuildTree(treeView1, imageList1,"tb_EmpInfo");
            this.skinCaptionPanel1.Visible = true;
            
               
        }

        private int GetIntCount() 
        {
            int intresult=0;
            tbemp.intEmpId = txtID.Text;
            tbemp.strEmpAddress = txtAddress.Text;
            tbemp.strEmpDept = txtDepot.Text;
            tbemp.strEmpLoginName = txtLogin.Text;
            tbemp.strEmpLoginPwd = txtLoginKey.Text;
            tbemp.strEmpName = txtName.Text;
            tbemp.strEmpPhone = txtPhone.Text;
            tbemp.strEmpPost = txtPost.Text;
            tbemp.strEmpSex = comboBox1.Text;
            tbemp.daEmpBirthday = dateTimePicker1.Value;
            intresult = 1;
            return intresult;


        }












        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode!=null)
            {
                if (treeView1.SelectedNode.Tag != null) 
                {
                    FillControls(treeView1.SelectedNode.Tag.ToString(), "tb_EmpInfo");
                   
                        try
                        {
                            imgByteIn = emp.ShowPic(treeView1.SelectedNode.Tag.ToString());
                            MemoryStream stream = new MemoryStream(imgByteIn);
                            Bitmap bp = new Bitmap(stream);
                            this.pictureBox1.Image = bp;
                        }
                        catch
                        {
                            MessageBox.Show("读取图片失败!");
                            pictureBox1.Image = null;
                        }
                    

                    
                }
            }
        }

        private void FillControls(string strWhere,string TableName) 
        {
            DataTable dt = emp.FillEmp(strWhere,TableName);
            txtID.Text=dt.Rows[0]["EmpId"].ToString();
            txtName.Text = dt.Rows[0]["EmpName"].ToString();
            txtLogin.Text = dt.Rows[0]["EmpLoginName"].ToString();
            txtLoginKey.Text = dt.Rows[0]["EmpLoginPwd"].ToString();
            comboBox1.Text=dt.Rows[0]["EmpSex"].ToString();
            dateTimePicker1.Text = dt.Rows[0]["EmpBirthday"].ToString();
            txtDepot.Text = dt.Rows[0]["EmpDept"].ToString();
            txtPost.Text = dt.Rows[0]["EmpPost"].ToString();
            txtPhone.Text=dt.Rows[0]["EmpPhone"].ToString();
            txtAddress.Text = dt.Rows[0]["EmpAddress"].ToString();
        }
         
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog();
            openF.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            if (openF.ShowDialog(this) == DialogResult.OK) 
            {
                try 
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(openF.FileName);
                    string strImg = openF.FileName.ToString();
                    FileStream fs = new FileStream(strImg,FileMode.Open,FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                   imgByteIn =br.ReadBytes((int)fs.Length);
                }
                catch
                {
                    MessageBox.Show("选择图片有误！","错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    pictureBox1.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetIntCount() == 1) 
            {
                if (emp.tb_EmpInfoMethodUpdate(tbemp) == 1) 
                {
                    
                    if (emp.picSql(imgByteIn, tbemp) == 1) 
                    {
                        MessageBox.Show("yes!");
                    }

                }
            }
        }





    }
}
