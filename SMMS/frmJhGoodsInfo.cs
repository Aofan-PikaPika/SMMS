using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using SMMS.ClassInfo;
using SMMS.GoodMethod;
using System.Data.SqlClient;

namespace SMMS
{
    public partial class frmJhGoodsInfo :Skin_Mac
    {
        public frmJhGoodsInfo()
        {
            InitializeComponent();
        }

        tb_JhGoodsInfo jhGood = new tb_JhGoodsInfo();
        tb_JhGoodsInfoMenthod jhMenthod = new tb_JhGoodsInfoMenthod();
        public static int intFalg = 0;
        
        private void ControlStatus() 
        {
            this.toolSave.Enabled = true;
            this.toolAdd.Enabled = false;
            this.toolCancel.Enabled = true;
            this.toolAmend.Enabled = false;
            this.toolDelete.Enabled = false;
        }
        public void ClearControl() 
        {
            txtGoodsNum.Text = "";
            txtGoodsRemark.Text = "";
            txtGoodsSellPrice.Text = "";
            txtJhCompName.Text = "";
            txtGoodsNeedPrice.Text = "";
            txtGoodsNoPrice.Text = "";
            txtGoodsName.Text = "";
            txtEmpId.Text = "";
            cmbDepotName.Text = "";
            txtGoodsID.Text = "";
            txtEmpId.Text = "";
            cmbDepotName.Text = "";
            txtGoodsJhPrice.Text = "";
        }
        public int getIntCount() 
        {
            int intResult = 0;
            if(intFalg==1)
            {
                if (txtGoodsID.Text == "") 
                {
                    MessageBox.Show("商品编号不能为空！");
                    return intResult;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空！");
                    return intResult;
                }
                if (txtJhCompName.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！");
                    return intResult;
                }
                if (txtEmpId.Text == "")
                {
                    MessageBox.Show("进货人姓名不能为空！");
                    return intResult;
                }
                if (txtGoodsNum.Text == "")
                {
                    MessageBox.Show("数量不能为空！");
                    return intResult;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("进货单价不能为空！");
                    return intResult;
                }

            }
            if (intFalg == 2)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("商品编号不能为空！选择要修改记录", "提示");
                    return intResult;
                }

            }
            if (intFalg == 3)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("商品编号不能为空！选择要删除记录", "提示");
                    return intResult;
                }
            }
            jhGood.strGoodsID = txtGoodsID.Text;
            jhGood.strEmpId = txtEmpId.Text;
            jhGood.strJhCompName = txtJhCompName.Text;
            jhGood.strDepotName = cmbDepotName.Text;
            jhGood.strGoodsNum = int.Parse(txtGoodsNum.Text);
            jhGood.strGoodsName = txtGoodsName.Text;
            jhGood.strGoodsUnit = cmbGoodsUnit.Text;
            jhGood.deGoodsJhPrice = txtGoodsJhPrice.Text;
            jhGood.deGoodsNeedPrice = txtGoodsNeedPrice.Text;
            jhGood.deGoodsNoPrice = txtGoodsNoPrice.Text;
            jhGood.deGoodsSellPrice = txtGoodsSellPrice.Text;
            jhGood.strGoodsRemark = txtGoodsRemark.Text;
            jhGood.daGoodTime = dateTimePicker1.Value;
            if (intFalg != 3)
            {
                jhGood.Falg = 0;
            }
            else 
            {
                jhGood.Falg = 1;
            }
            intResult = 1;
            return intResult;
        }

        private void skinFlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmJhGoodsInfo_Load(object sender, EventArgs e)
        {
            jhMenthod.tb_JhGoodsInfoFind("",5,dataGridView1);
            dataGridView1.Show();
            skinProgressIndicator1.Visible = false;
            this.toolSave.Enabled = false;
        }


        private void FillControls() 
        {
            try 
            {
                SqlDataReader sqldr = jhMenthod.tb_JhGoodsInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(), 1);
                sqldr.Read();
                if(sqldr.HasRows)
                {
                    txtEmpId.Text = sqldr[1].ToString();
                    txtGoodsName.Text = sqldr[4].ToString();
                    cmbDepotName.Text = sqldr[3].ToString();


                    txtGoodsNum.Text = sqldr[5].ToString();
                    cmbGoodsUnit.Text = sqldr[6].ToString();
                    txtGoodsJhPrice.Text = sqldr[7].ToString();
                    txtGoodsNeedPrice.Text = sqldr[9].ToString();
                    txtGoodsNoPrice.Text = sqldr[10].ToString();
                    txtGoodsSellPrice.Text = sqldr[8].ToString();
                    txtGoodsRemark.Text = sqldr[11].ToString();
                    txtJhCompName.Text = sqldr[2].ToString();

                    txtGoodsID.Text = sqldr[0].ToString();
                    txtGoodsID.Enabled = false;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            skinProgressIndicator1.Visible = true;
            skinProgressIndicator1.Start();
            timer1.Interval = 100;
           
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            
            if (getIntCount() == 1) 
            {
              
                timer1.Enabled = true;

                if (intFalg == 1) 
                {
                    

                    if (jhMenthod.tb_JhGoodsInfoMenthodAdd(jhGood) == 1)
                    {
                        MessageBox.Show("添加成功!\n点击返回以继续操作", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearControl();

                    }
                    else 
                    {
                        MessageBox.Show("添加失败!\n点击返回以重新操作", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearControl();

                    }
                }
                if (intFalg == 2)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodUpdate(jhGood) == 1)
                    {
                        MessageBox.Show("修改成功!\n点击返回以继续操作", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearControl();
                    }
                    else
                    {
                        MessageBox.Show("修改失败!\n点击返回以重新操作", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearControl();
                    }

                }
                if (intFalg == 3)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodDelete(jhGood) == 1)
                    {
                        MessageBox.Show("删除成功!\n点击返回以继续操作", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearControl();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!\n点击返回以重新操作", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearControl();
                    }

                }

                skinProgressIndicator1.Stop();
                skinProgressIndicator1.Visible = false;
                timer1.Enabled = false;
                this.toolSave.Enabled = false;

            }

        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            
            ClearControl();
            toolDelete.Enabled = true;
            toolAdd.Enabled = true;
            toolAmend.Enabled = true;
            toolAdd.BackColor = Color.FromArgb(0, 240, 240, 240);
            toolDelete.BackColor = Color.FromArgb(0, 240, 240, 240);
            toolAmend.BackColor = Color.FromArgb(0, 240, 240, 240);
            toolSave.Enabled = false;

        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControl();
            intFalg = 1;
            txtGoodsID.Text = jhMenthod.JhGoodsID();
            txtGoodsID.Enabled = false;
            toolAdd.BackColor = Color.Gold;



        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControl();
            intFalg = 2;
            toolAmend.BackColor = Color.Gold;

        }

        private void toolDelete_Click(object sender, EventArgs e)
        {

            ControlStatus();
            intFalg = 3;
            toolDelete.BackColor = Color.Gold;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(intFalg==2||intFalg==3)
            {
                FillControls();

            }
        }

        private void txtGoodsNoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }

        }

        private void txtGoodsJhPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txtGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }


        

        private void txtGoodsSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }     
        }

        private void txtGoodsJhPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtGoodsNum.Text != ""&&txtGoodsJhPrice.Text!="")
            {
                txtGoodsNeedPrice.Text = Convert.ToString(Convert.ToInt32(txtGoodsJhPrice.Text) * Convert.ToInt32(txtGoodsNum.Text));
            }

        }

        

        







    }
}
