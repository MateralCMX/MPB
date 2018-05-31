namespace MPB.UI.WinForm
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextDBAddress = new System.Windows.Forms.TextBox();
            this.TextDBName = new System.Windows.Forms.TextBox();
            this.TextDBAccount = new System.Windows.Forms.TextBox();
            this.TextDBPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.CheckTypeScript = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckCSharp = new System.Windows.Forms.CheckBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TextCreatePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextProjectName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据库账号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据库密码：";
            // 
            // TextDBAddress
            // 
            this.TextDBAddress.Location = new System.Drawing.Point(94, 20);
            this.TextDBAddress.Name = "TextDBAddress";
            this.TextDBAddress.Size = new System.Drawing.Size(100, 21);
            this.TextDBAddress.TabIndex = 0;
            this.TextDBAddress.Text = "127.0.0.1";
            // 
            // TextDBName
            // 
            this.TextDBName.Location = new System.Drawing.Point(94, 47);
            this.TextDBName.Name = "TextDBName";
            this.TextDBName.Size = new System.Drawing.Size(100, 21);
            this.TextDBName.TabIndex = 1;
            this.TextDBName.Text = "BeiDouBMSDB";
            // 
            // TextDBAccount
            // 
            this.TextDBAccount.Location = new System.Drawing.Point(94, 74);
            this.TextDBAccount.Name = "TextDBAccount";
            this.TextDBAccount.Size = new System.Drawing.Size(100, 21);
            this.TextDBAccount.TabIndex = 2;
            this.TextDBAccount.Text = "sa";
            // 
            // TextDBPassword
            // 
            this.TextDBPassword.Location = new System.Drawing.Point(94, 101);
            this.TextDBPassword.Name = "TextDBPassword";
            this.TextDBPassword.Size = new System.Drawing.Size(100, 21);
            this.TextDBPassword.TabIndex = 3;
            this.TextDBPassword.Text = "123456";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextDBPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextDBAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextDBName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextDBAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreateFile);
            this.groupBox2.Controls.Add(this.CheckTypeScript);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CheckCSharp);
            this.groupBox2.Controls.Add(this.BtnBrowse);
            this.groupBox2.Controls.Add(this.TextCreatePath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TextProjectName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成配置";
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Location = new System.Drawing.Point(6, 101);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(538, 23);
            this.BtnCreateFile.TabIndex = 20;
            this.BtnCreateFile.Text = "生成";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // CheckTypeScript
            // 
            this.CheckTypeScript.AutoSize = true;
            this.CheckTypeScript.Checked = true;
            this.CheckTypeScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckTypeScript.Location = new System.Drawing.Point(123, 76);
            this.CheckTypeScript.Name = "CheckTypeScript";
            this.CheckTypeScript.Size = new System.Drawing.Size(84, 16);
            this.CheckTypeScript.TabIndex = 8;
            this.CheckTypeScript.Text = "TypeScript";
            this.CheckTypeScript.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "生成类型：";
            // 
            // CheckCSharp
            // 
            this.CheckCSharp.AutoSize = true;
            this.CheckCSharp.Checked = true;
            this.CheckCSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCSharp.Location = new System.Drawing.Point(81, 76);
            this.CheckCSharp.Name = "CheckCSharp";
            this.CheckCSharp.Size = new System.Drawing.Size(36, 16);
            this.CheckCSharp.TabIndex = 7;
            this.CheckCSharp.Text = "C#";
            this.CheckCSharp.UseVisualStyleBackColor = true;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(510, 47);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(38, 23);
            this.BtnBrowse.TabIndex = 6;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TextCreatePath
            // 
            this.TextCreatePath.Location = new System.Drawing.Point(81, 47);
            this.TextCreatePath.Name = "TextCreatePath";
            this.TextCreatePath.Size = new System.Drawing.Size(423, 21);
            this.TextCreatePath.TabIndex = 5;
            this.TextCreatePath.Text = "E:\\Project\\Materal项目生成器\\Application\\Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "生成位置：";
            // 
            // TextProjectName
            // 
            this.TextProjectName.Location = new System.Drawing.Point(81, 20);
            this.TextProjectName.Name = "TextProjectName";
            this.TextProjectName.Size = new System.Drawing.Size(423, 21);
            this.TextProjectName.TabIndex = 4;
            this.TextProjectName.Text = "MateralProject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "项目名称：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 154);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体生成工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextDBAddress;
        private System.Windows.Forms.TextBox TextDBName;
        private System.Windows.Forms.TextBox TextDBAccount;
        private System.Windows.Forms.TextBox TextDBPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCreateFile;
        private System.Windows.Forms.CheckBox CheckTypeScript;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckCSharp;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TextCreatePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextProjectName;
        private System.Windows.Forms.Label label5;
    }
}

