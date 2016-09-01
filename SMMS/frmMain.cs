using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace SMMS
{
    public partial class frmMain : Skin_Mac
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string strName) 
        {
            InitializeComponent();
            this.Text = "你好，"+strName;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            
        }

        private void 商品进货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJhGoodsInfo jh = new frmJhGoodsInfo();
            jh.Owner = this;
            jh.ShowDialog();
        }

        private void 进货查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindGood finder = new frmFindGood();
            finder.Owner = this;
            finder.ShowDialog();
        }

        private void 库存报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpInfo emp = new frmEmpInfo();
            emp.Owner = this;
            emp.ShowDialog();
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.skinLabel2.Text = "当前时间：" + DateTime.Now.ToLongTimeString() ;
        }
    }
}
