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
    public partial class frmFindGood : Skin_Mac
    {
        public frmFindGood()
        {
            InitializeComponent();
        }

        tb_JhGoodsInfoMenthod jh = new tb_JhGoodsInfoMenthod();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if(comboBox1.Text!=""&&comboBox1.Text!="查询所有信息"&&textBox1.Text=="")
            {
                MessageBox.Show("输入查询信息");
                return;
            }
            switch (comboBox1.Text)
            {
                case "商品编号":
                    jh.tb_JhGoodsInfoFind(textBox1.Text, 1, dataGridView1);
                    comboBox1.SelectedIndex=0;
                    break;
                case "商品名称":
                    jh.tb_JhGoodsInfoFind(textBox1.Text, 2, dataGridView1);
                    comboBox1.SelectedIndex = 0;
                    break;
                case"查询所有信息":
                    jh.tb_JhGoodsInfoFind(textBox1.Text,5,dataGridView1);
                    comboBox1.SelectedIndex = 0;
                    break;
            }
        }
        
        







    }
}
