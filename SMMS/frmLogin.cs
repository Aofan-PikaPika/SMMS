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

namespace SMMS
{
    public partial class frmLogin : Skin_Mac
    {
       
        public frmLogin()
        {
            InitializeComponent();
            txtID.Text = "";
            txtPWD.Text = "";
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            tb_EmpInfoMethod tbEmp = new tb_EmpInfoMethod();
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "用户名不能为空");
                return;
            }
            if(txtPWD.Text=="")
            {
                errorProvider2.SetError(txtPWD,"密码不能为空");
                return;

            }
            if (tbEmp.tb_EmpInfoFind(txtID.Text, txtPWD.Text, 2) == 1)
            {
                frmMain frm = new frmMain(txtID.Text);
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("登录失败！");
            }
            
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
