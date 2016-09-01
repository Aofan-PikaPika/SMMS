namespace SMMS
{
    partial class frmJhGoodsInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJhGoodsInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGoodsID = new CCWin.SkinControl.SkinWaterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJhCompName = new CCWin.SkinControl.SkinWaterTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.cmbGoodsUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGoodsJhPrice = new CCWin.SkinControl.SkinWaterTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGoodsSellPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDepotName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGoodsNeedPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGoodsNoPrice = new CCWin.SkinControl.SkinWaterTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGoodsRemark = new System.Windows.Forms.RichTextBox();
            this.skinProgressIndicator1 = new CCWin.SkinControl.SkinProgressIndicator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.toolDelete});
            this.toolStrip1.Location = new System.Drawing.Point(4, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(88, 22);
            this.toolSave.Text = "执行并保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(52, 22);
            this.toolCancel.Text = "返回";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Margin = new System.Windows.Forms.Padding(500, 1, 10, 2);
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(52, 22);
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(52, 22);
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(52, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsID);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtJhCompName);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsNum);
            this.flowLayoutPanel1.Controls.Add(this.cmbGoodsUnit);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsJhPrice);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsSellPrice);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txtEmpId);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.cmbDepotName);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsNeedPrice);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsNoPrice);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.txtGoodsRemark);
            this.flowLayoutPanel1.Controls.Add(this.skinProgressIndicator1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 57);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(30, 15, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(888, 471);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "进货编号:";
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(95, 15);
            this.txtGoodsID.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(273, 21);
            this.txtGoodsID.TabIndex = 1;
            this.txtGoodsID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtGoodsID.WaterText = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(150, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品名称:";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(586, 15);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(269, 21);
            this.txtGoodsName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "供应商名称:";
            // 
            // txtJhCompName
            // 
            this.txtJhCompName.Location = new System.Drawing.Point(94, 54);
            this.txtJhCompName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtJhCompName.Name = "txtJhCompName";
            this.txtJhCompName.Size = new System.Drawing.Size(274, 21);
            this.txtJhCompName.TabIndex = 6;
            this.txtJhCompName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtJhCompName.WaterText = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(150, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "进货数量:";
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(586, 54);
            this.txtGoodsNum.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(197, 21);
            this.txtGoodsNum.TabIndex = 8;
            this.txtGoodsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsNum_KeyPress);
            // 
            // cmbGoodsUnit
            // 
            this.cmbGoodsUnit.FormattingEnabled = true;
            this.cmbGoodsUnit.Items.AddRange(new object[] {
            "个",
            "箱",
            "公斤"});
            this.cmbGoodsUnit.Location = new System.Drawing.Point(789, 54);
            this.cmbGoodsUnit.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cmbGoodsUnit.Name = "cmbGoodsUnit";
            this.cmbGoodsUnit.Size = new System.Drawing.Size(66, 20);
            this.cmbGoodsUnit.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "进货单价:";
            // 
            // txtGoodsJhPrice
            // 
            this.txtGoodsJhPrice.Location = new System.Drawing.Point(95, 93);
            this.txtGoodsJhPrice.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsJhPrice.Name = "txtGoodsJhPrice";
            this.txtGoodsJhPrice.Size = new System.Drawing.Size(170, 21);
            this.txtGoodsJhPrice.TabIndex = 10;
            this.txtGoodsJhPrice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtGoodsJhPrice.WaterText = "";
            this.txtGoodsJhPrice.TextChanged += new System.EventHandler(this.txtGoodsJhPrice_TextChanged);
            this.txtGoodsJhPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsJhPrice_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(271, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(150, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "销售单价:";
            // 
            // txtGoodsSellPrice
            // 
            this.txtGoodsSellPrice.Location = new System.Drawing.Point(586, 93);
            this.txtGoodsSellPrice.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsSellPrice.Name = "txtGoodsSellPrice";
            this.txtGoodsSellPrice.Size = new System.Drawing.Size(269, 21);
            this.txtGoodsSellPrice.TabIndex = 13;
            this.txtGoodsSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsSellPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "进货日期:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 132);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 21);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(150, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "进货员工:";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(586, 132);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(269, 21);
            this.txtEmpId.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "所属仓库:";
            // 
            // cmbDepotName
            // 
            this.cmbDepotName.FormattingEnabled = true;
            this.cmbDepotName.Items.AddRange(new object[] {
            "第1号仓库",
            "第2号仓库",
            "第3号仓库"});
            this.cmbDepotName.Location = new System.Drawing.Point(95, 171);
            this.cmbDepotName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cmbDepotName.Name = "cmbDepotName";
            this.cmbDepotName.Size = new System.Drawing.Size(273, 20);
            this.cmbDepotName.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(150, 20, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "应付金额:";
            // 
            // txtGoodsNeedPrice
            // 
            this.txtGoodsNeedPrice.Location = new System.Drawing.Point(586, 171);
            this.txtGoodsNeedPrice.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsNeedPrice.Name = "txtGoodsNeedPrice";
            this.txtGoodsNeedPrice.Size = new System.Drawing.Size(269, 21);
            this.txtGoodsNeedPrice.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 215);
            this.label11.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "实付金额:";
            // 
            // txtGoodsNoPrice
            // 
            this.txtGoodsNoPrice.Location = new System.Drawing.Point(95, 210);
            this.txtGoodsNoPrice.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsNoPrice.Name = "txtGoodsNoPrice";
            this.txtGoodsNoPrice.Size = new System.Drawing.Size(274, 21);
            this.txtGoodsNoPrice.TabIndex = 23;
            this.txtGoodsNoPrice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtGoodsNoPrice.WaterText = "";
            this.txtGoodsNoPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsNoPrice_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(547, 215);
            this.label12.Margin = new System.Windows.Forms.Padding(175, 20, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "备注:";
            // 
            // txtGoodsRemark
            // 
            this.txtGoodsRemark.Location = new System.Drawing.Point(588, 210);
            this.txtGoodsRemark.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGoodsRemark.Name = "txtGoodsRemark";
            this.txtGoodsRemark.Size = new System.Drawing.Size(267, 70);
            this.txtGoodsRemark.TabIndex = 25;
            this.txtGoodsRemark.Text = "";
            // 
            // skinProgressIndicator1
            // 
            this.skinProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressIndicator1.CircleColor = System.Drawing.Color.Purple;
            this.skinProgressIndicator1.Location = new System.Drawing.Point(400, 333);
            this.skinProgressIndicator1.Margin = new System.Windows.Forms.Padding(400, 50, 3, 0);
            this.skinProgressIndicator1.Name = "skinProgressIndicator1";
            this.skinProgressIndicator1.Percentage = 0F;
            this.skinProgressIndicator1.Size = new System.Drawing.Size(123, 123);
            this.skinProgressIndicator1.TabIndex = 29;
            this.skinProgressIndicator1.Text = "skinProgressIndicator1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(30, 471);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(30, 15, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(825, 153);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(568, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "选择操作状态：";
            // 
            // frmJhGoodsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 532);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmJhGoodsInfo";
            this.Text = "frmCompanyInfo";
            this.Load += new System.EventHandler(this.frmJhGoodsInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinWaterTextBox txtGoodsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinWaterTextBox txtJhCompName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinWaterTextBox txtGoodsJhPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGoodsSellPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGoodsNeedPrice;
        private System.Windows.Forms.Label label11;
        private CCWin.SkinControl.SkinWaterTextBox txtGoodsNoPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtGoodsRemark;
        private System.Windows.Forms.ComboBox cmbGoodsUnit;
        private System.Windows.Forms.ComboBox cmbDepotName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinProgressIndicator skinProgressIndicator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;

    }
}