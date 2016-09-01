namespace SMMS
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.基本档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品进货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进货查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品销售ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品退货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存报警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本档案ToolStripMenuItem,
            this.进货管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.系统维护ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 32);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(1012, 25);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 基本档案ToolStripMenuItem
            // 
            this.基本档案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息ToolStripMenuItem,
            this.供应商信息ToolStripMenuItem});
            this.基本档案ToolStripMenuItem.Name = "基本档案ToolStripMenuItem";
            this.基本档案ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本档案ToolStripMenuItem.Text = "基本档案";
            // 
            // 员工信息ToolStripMenuItem
            // 
            this.员工信息ToolStripMenuItem.Name = "员工信息ToolStripMenuItem";
            this.员工信息ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.员工信息ToolStripMenuItem.Text = "员工信息[&E]";
            this.员工信息ToolStripMenuItem.Click += new System.EventHandler(this.员工信息ToolStripMenuItem_Click);
            // 
            // 供应商信息ToolStripMenuItem
            // 
            this.供应商信息ToolStripMenuItem.Name = "供应商信息ToolStripMenuItem";
            this.供应商信息ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.供应商信息ToolStripMenuItem.Text = "供应商信息[&Q]";
            // 
            // 进货管理ToolStripMenuItem
            // 
            this.进货管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品进货ToolStripMenuItem,
            this.进货查询ToolStripMenuItem});
            this.进货管理ToolStripMenuItem.Name = "进货管理ToolStripMenuItem";
            this.进货管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.进货管理ToolStripMenuItem.Text = "进货管理";
            // 
            // 商品进货ToolStripMenuItem
            // 
            this.商品进货ToolStripMenuItem.Name = "商品进货ToolStripMenuItem";
            this.商品进货ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品进货ToolStripMenuItem.Text = "商品进货[S]";
            this.商品进货ToolStripMenuItem.Click += new System.EventHandler(this.商品进货ToolStripMenuItem_Click);
            // 
            // 进货查询ToolStripMenuItem
            // 
            this.进货查询ToolStripMenuItem.Name = "进货查询ToolStripMenuItem";
            this.进货查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.进货查询ToolStripMenuItem.Text = "进货查询[F]";
            this.进货查询ToolStripMenuItem.Click += new System.EventHandler(this.进货查询ToolStripMenuItem_Click);
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品销售ToolStripMenuItem,
            this.商品退货ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 商品销售ToolStripMenuItem
            // 
            this.商品销售ToolStripMenuItem.Name = "商品销售ToolStripMenuItem";
            this.商品销售ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品销售ToolStripMenuItem.Text = "商品销售[&G]";
            // 
            // 商品退货ToolStripMenuItem
            // 
            this.商品退货ToolStripMenuItem.Name = "商品退货ToolStripMenuItem";
            this.商品退货ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品退货ToolStripMenuItem.Text = "商品退货[&O]";
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存报警ToolStripMenuItem,
            this.库存查询ToolStripMenuItem});
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            // 
            // 库存报警ToolStripMenuItem
            // 
            this.库存报警ToolStripMenuItem.Name = "库存报警ToolStripMenuItem";
            this.库存报警ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.库存报警ToolStripMenuItem.Text = "库存报警[&J]";
            this.库存报警ToolStripMenuItem.Click += new System.EventHandler(this.库存报警ToolStripMenuItem_Click);
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.库存查询ToolStripMenuItem.Text = "库存查询[&M]";
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据备份ToolStripMenuItem,
            this.数据还原ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // 数据备份ToolStripMenuItem
            // 
            this.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem";
            this.数据备份ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据备份ToolStripMenuItem.Text = "数据备份[&H]";
            // 
            // 数据还原ToolStripMenuItem
            // 
            this.数据还原ToolStripMenuItem.Name = "数据还原ToolStripMenuItem";
            this.数据还原ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据还原ToolStripMenuItem.Text = "数据还原[&I]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(4, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(704, 435);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(642, 438);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(59, 17);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "当前日期:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(844, 437);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(0, 17);
            this.skinLabel2.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 460);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.skinMenuStrip1);
            this.MainMenuStrip = this.skinMenuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品进货ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进货查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品销售ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品退货ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存报警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据还原ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;


    }
}

