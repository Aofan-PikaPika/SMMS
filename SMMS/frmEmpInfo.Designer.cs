namespace SMMS
{
    partial class frmEmpInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpInfo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinCaptionPanel1 = new CCWin.SkinControl.SkinCaptionPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Laddress = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.txtLoginKey = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Lphone = new System.Windows.Forms.Label();
            this.Lpost = new System.Windows.Forms.Label();
            this.Ldepot = new System.Windows.Forms.Label();
            this.Lbirthday = new System.Windows.Forms.Label();
            this.Lsex = new System.Windows.Forms.Label();
            this.LLKey = new System.Windows.Forms.Label();
            this.LLname = new System.Windows.Forms.Label();
            this.LNAME = new System.Windows.Forms.Label();
            this.LID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.skinCaptionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "16基础设置.gif");
            this.imageList1.Images.SetKeyName(1, "16操作员设置.gif");
            this.imageList1.Images.SetKeyName(2, "16代理管理.gif");
            this.imageList1.Images.SetKeyName(3, "16代理级别.gif");
            this.imageList1.Images.SetKeyName(4, "16人员设置.gif");
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(4, 32);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinCaptionPanel1);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.skinSplitContainer1.Panel2.Controls.Add(this.button1);
            this.skinSplitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtAddress);
            this.skinSplitContainer1.Panel2.Controls.Add(this.Laddress);
            this.skinSplitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtPhone);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtPost);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtDepot);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtLoginKey);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtLogin);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtName);
            this.skinSplitContainer1.Panel2.Controls.Add(this.txtID);
            this.skinSplitContainer1.Panel2.Controls.Add(this.Lphone);
            this.skinSplitContainer1.Panel2.Controls.Add(this.Lpost);
            this.skinSplitContainer1.Panel2.Controls.Add(this.Ldepot);
            this.skinSplitContainer1.Panel2.Controls.Add(this.Lbirthday);
            this.skinSplitContainer1.Panel2.Controls.Add(this.Lsex);
            this.skinSplitContainer1.Panel2.Controls.Add(this.LLKey);
            this.skinSplitContainer1.Panel2.Controls.Add(this.LLname);
            this.skinSplitContainer1.Panel2.Controls.Add(this.LNAME);
            this.skinSplitContainer1.Panel2.Controls.Add(this.LID);
            this.skinSplitContainer1.Panel2.Controls.Add(this.label1);
            this.skinSplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinSplitContainer1.Size = new System.Drawing.Size(925, 420);
            this.skinSplitContainer1.SplitterDistance = 211;
            this.skinSplitContainer1.SplitterWidth = 10;
            this.skinSplitContainer1.TabIndex = 2;
            // 
            // skinCaptionPanel1
            // 
            this.skinCaptionPanel1.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCaptionPanel1.Controls.Add(this.treeView1);
            this.skinCaptionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinCaptionPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinCaptionPanel1.Name = "skinCaptionPanel1";
            this.skinCaptionPanel1.Size = new System.Drawing.Size(211, 420);
            this.skinCaptionPanel1.TabIndex = 2;
            this.skinCaptionPanel1.Text = "导航栏";
            this.skinCaptionPanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(2, 24);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(207, 394);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SMMS.Properties.Resources.upload;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(481, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "保    存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(326, 284);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(364, 21);
            this.txtAddress.TabIndex = 21;
            // 
            // Laddress
            // 
            this.Laddress.AutoSize = true;
            this.Laddress.Location = new System.Drawing.Point(266, 293);
            this.Laddress.Name = "Laddress";
            this.Laddress.Size = new System.Drawing.Size(65, 12);
            this.Laddress.TabIndex = 20;
            this.Laddress.Text = "家庭住址：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(97, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 20);
            this.comboBox1.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(97, 284);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 21);
            this.txtPhone.TabIndex = 18;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(326, 225);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(122, 21);
            this.txtPost.TabIndex = 17;
            // 
            // txtDepot
            // 
            this.txtDepot.Location = new System.Drawing.Point(97, 231);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.Size = new System.Drawing.Size(122, 21);
            this.txtDepot.TabIndex = 16;
            // 
            // txtLoginKey
            // 
            this.txtLoginKey.Location = new System.Drawing.Point(326, 104);
            this.txtLoginKey.Name = "txtLoginKey";
            this.txtLoginKey.Size = new System.Drawing.Size(122, 21);
            this.txtLoginKey.TabIndex = 13;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(97, 104);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(122, 21);
            this.txtLogin.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(326, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 21);
            this.txtName.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 21);
            this.txtID.TabIndex = 10;
            // 
            // Lphone
            // 
            this.Lphone.AutoSize = true;
            this.Lphone.Location = new System.Drawing.Point(38, 293);
            this.Lphone.Name = "Lphone";
            this.Lphone.Size = new System.Drawing.Size(65, 12);
            this.Lphone.TabIndex = 9;
            this.Lphone.Text = "联系电话：";
            // 
            // Lpost
            // 
            this.Lpost.AutoSize = true;
            this.Lpost.Location = new System.Drawing.Point(279, 234);
            this.Lpost.Name = "Lpost";
            this.Lpost.Size = new System.Drawing.Size(41, 12);
            this.Lpost.TabIndex = 8;
            this.Lpost.Text = "职位：";
            // 
            // Ldepot
            // 
            this.Ldepot.AutoSize = true;
            this.Ldepot.Location = new System.Drawing.Point(38, 240);
            this.Ldepot.Name = "Ldepot";
            this.Ldepot.Size = new System.Drawing.Size(65, 12);
            this.Ldepot.TabIndex = 7;
            this.Ldepot.Text = "所属部门：";
            // 
            // Lbirthday
            // 
            this.Lbirthday.AutoSize = true;
            this.Lbirthday.Location = new System.Drawing.Point(279, 173);
            this.Lbirthday.Name = "Lbirthday";
            this.Lbirthday.Size = new System.Drawing.Size(41, 12);
            this.Lbirthday.TabIndex = 6;
            this.Lbirthday.Text = "生日：";
            // 
            // Lsex
            // 
            this.Lsex.AutoSize = true;
            this.Lsex.Location = new System.Drawing.Point(62, 173);
            this.Lsex.Name = "Lsex";
            this.Lsex.Size = new System.Drawing.Size(41, 12);
            this.Lsex.TabIndex = 5;
            this.Lsex.Text = "性别：";
            // 
            // LLKey
            // 
            this.LLKey.AutoSize = true;
            this.LLKey.Location = new System.Drawing.Point(266, 113);
            this.LLKey.Name = "LLKey";
            this.LLKey.Size = new System.Drawing.Size(65, 12);
            this.LLKey.TabIndex = 4;
            this.LLKey.Text = "登录密码：";
            // 
            // LLname
            // 
            this.LLname.AutoSize = true;
            this.LLname.Location = new System.Drawing.Point(50, 113);
            this.LLname.Name = "LLname";
            this.LLname.Size = new System.Drawing.Size(53, 12);
            this.LLname.TabIndex = 3;
            this.LLname.Text = "登录名：";
            // 
            // LNAME
            // 
            this.LNAME.AutoSize = true;
            this.LNAME.Location = new System.Drawing.Point(266, 56);
            this.LNAME.Name = "LNAME";
            this.LNAME.Size = new System.Drawing.Size(65, 12);
            this.LNAME.TabIndex = 2;
            this.LNAME.Text = "员工姓名：";
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Location = new System.Drawing.Point(38, 56);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(65, 12);
            this.LID.TabIndex = 1;
            this.LID.Text = "员工编号：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(309, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "个 人 资 料";
            // 
            // frmEmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 456);
            this.Controls.Add(this.skinSplitContainer1);
            this.Name = "frmEmpInfo";
            this.Text = "frmEmpInfo";
            this.Load += new System.EventHandler(this.frmEmpInfo_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinCaptionPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label Lpost;
        private System.Windows.Forms.Label Ldepot;
        private System.Windows.Forms.Label Lbirthday;
        private System.Windows.Forms.Label Lsex;
        private System.Windows.Forms.Label LLKey;
        private System.Windows.Forms.Label LLname;
        private System.Windows.Forms.Label LNAME;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.TextBox txtLoginKey;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Lphone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Laddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}