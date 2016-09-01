namespace SMMS
{
    partial class frmLogin
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtID = new CCWin.SkinControl.SkinTextBox();
            this.txtPWD = new CCWin.SkinControl.SkinTextBox();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnNO = new CCWin.SkinControl.SkinButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(120, 80);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(90, 22);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "登录名称：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(120, 132);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(90, 22);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "登录密码：";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.DownBack = null;
            this.txtID.Icon = null;
            this.txtID.IconIsButton = false;
            this.txtID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtID.IsPasswordChat = '\0';
            this.txtID.IsSystemPasswordChar = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(213, 74);
            this.txtID.Margin = new System.Windows.Forms.Padding(0);
            this.txtID.MaxLength = 32767;
            this.txtID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtID.MouseBack = null;
            this.txtID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.NormlBack = null;
            this.txtID.Padding = new System.Windows.Forms.Padding(5);
            this.txtID.ReadOnly = false;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.Size = new System.Drawing.Size(242, 28);
            // 
            // 
            // 
            this.txtID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtID.SkinTxt.Name = "BaseText";
            this.txtID.SkinTxt.Size = new System.Drawing.Size(232, 18);
            this.txtID.SkinTxt.TabIndex = 0;
            this.txtID.SkinTxt.Text = "skinTextBox1";
            this.txtID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtID.SkinTxt.WaterText = "";
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtID.WaterText = "";
            this.txtID.WordWrap = true;
            // 
            // txtPWD
            // 
            this.txtPWD.BackColor = System.Drawing.Color.Transparent;
            this.txtPWD.DownBack = null;
            this.txtPWD.Icon = null;
            this.txtPWD.IconIsButton = false;
            this.txtPWD.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPWD.IsPasswordChat = '●';
            this.txtPWD.IsSystemPasswordChar = true;
            this.txtPWD.Lines = new string[0];
            this.txtPWD.Location = new System.Drawing.Point(213, 126);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(0);
            this.txtPWD.MaxLength = 32767;
            this.txtPWD.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPWD.MouseBack = null;
            this.txtPWD.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPWD.Multiline = false;
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.NormlBack = null;
            this.txtPWD.Padding = new System.Windows.Forms.Padding(5);
            this.txtPWD.ReadOnly = false;
            this.txtPWD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPWD.Size = new System.Drawing.Size(242, 28);
            // 
            // 
            // 
            this.txtPWD.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPWD.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPWD.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPWD.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPWD.SkinTxt.Name = "BaseText";
            this.txtPWD.SkinTxt.PasswordChar = '●';
            this.txtPWD.SkinTxt.Size = new System.Drawing.Size(232, 18);
            this.txtPWD.SkinTxt.TabIndex = 0;
            this.txtPWD.SkinTxt.UseSystemPasswordChar = true;
            this.txtPWD.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPWD.SkinTxt.WaterText = "";
            this.txtPWD.TabIndex = 3;
            this.txtPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPWD.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPWD.WaterText = "";
            this.txtPWD.WordWrap = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(122, 196);
            this.btnOK.MouseBack = null;
            this.btnOK.MouseBaseColor = System.Drawing.Color.Lime;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(161, 36);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确   定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.Transparent;
            this.btnNO.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNO.DownBack = null;
            this.btnNO.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNO.Location = new System.Drawing.Point(341, 196);
            this.btnNO.MouseBack = null;
            this.btnNO.Name = "btnNO";
            this.btnNO.NormlBack = null;
            this.btnNO.Size = new System.Drawing.Size(161, 36);
            this.btnNO.TabIndex = 5;
            this.btnNO.Text = "取  消";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 263);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmLogin";
            this.Text = "欢 迎 登 录";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox txtID;
        private CCWin.SkinControl.SkinTextBox txtPWD;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnNO;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}