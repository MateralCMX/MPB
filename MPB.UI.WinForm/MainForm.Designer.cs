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
            this.SqlServerTextAddress = new System.Windows.Forms.TextBox();
            this.SqlServerTextName = new System.Windows.Forms.TextBox();
            this.SqlServerTextAccount = new System.Windows.Forms.TextBox();
            this.SqlServerTextPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SqlServerCheckAngular = new System.Windows.Forms.CheckBox();
            this.SqlServerBtnCreateFile = new System.Windows.Forms.Button();
            this.SqlServerCheckTypeScript = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SqlServerCheckCSharp = new System.Windows.Forms.CheckBox();
            this.SqlServerBtnBrowse = new System.Windows.Forms.Button();
            this.SqlServerTextCreatePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SqlServerTextProjectName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MySqlTextPort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MySqlTextPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MySqlTextAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MySqlTextName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MySqlTextAddress = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MySqlBtnCreateFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.MySqlCheckCSharp = new System.Windows.Forms.CheckBox();
            this.MySqlBtnBrowse = new System.Windows.Forms.Button();
            this.MySqlTextCreatePath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MySqlTextProjectName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // SqlServerTextAddress
            // 
            this.SqlServerTextAddress.Location = new System.Drawing.Point(94, 20);
            this.SqlServerTextAddress.Name = "SqlServerTextAddress";
            this.SqlServerTextAddress.Size = new System.Drawing.Size(100, 21);
            this.SqlServerTextAddress.TabIndex = 0;
            // 
            // SqlServerTextName
            // 
            this.SqlServerTextName.Location = new System.Drawing.Point(94, 47);
            this.SqlServerTextName.Name = "SqlServerTextName";
            this.SqlServerTextName.Size = new System.Drawing.Size(100, 21);
            this.SqlServerTextName.TabIndex = 1;
            // 
            // SqlServerTextAccount
            // 
            this.SqlServerTextAccount.Location = new System.Drawing.Point(94, 74);
            this.SqlServerTextAccount.Name = "SqlServerTextAccount";
            this.SqlServerTextAccount.Size = new System.Drawing.Size(100, 21);
            this.SqlServerTextAccount.TabIndex = 2;
            // 
            // SqlServerTextPassword
            // 
            this.SqlServerTextPassword.Location = new System.Drawing.Point(94, 101);
            this.SqlServerTextPassword.Name = "SqlServerTextPassword";
            this.SqlServerTextPassword.Size = new System.Drawing.Size(100, 21);
            this.SqlServerTextPassword.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SqlServerTextPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SqlServerTextAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SqlServerTextName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SqlServerTextAddress);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SqlServerCheckAngular);
            this.groupBox2.Controls.Add(this.SqlServerBtnCreateFile);
            this.groupBox2.Controls.Add(this.SqlServerCheckTypeScript);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SqlServerCheckCSharp);
            this.groupBox2.Controls.Add(this.SqlServerBtnBrowse);
            this.groupBox2.Controls.Add(this.SqlServerTextCreatePath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SqlServerTextProjectName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(232, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成配置";
            // 
            // SqlServerCheckAngular
            // 
            this.SqlServerCheckAngular.AutoSize = true;
            this.SqlServerCheckAngular.Checked = true;
            this.SqlServerCheckAngular.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SqlServerCheckAngular.Location = new System.Drawing.Point(213, 76);
            this.SqlServerCheckAngular.Name = "SqlServerCheckAngular";
            this.SqlServerCheckAngular.Size = new System.Drawing.Size(66, 16);
            this.SqlServerCheckAngular.TabIndex = 21;
            this.SqlServerCheckAngular.Text = "Angular";
            this.SqlServerCheckAngular.UseVisualStyleBackColor = true;
            // 
            // SqlServerBtnCreateFile
            // 
            this.SqlServerBtnCreateFile.Location = new System.Drawing.Point(6, 101);
            this.SqlServerBtnCreateFile.Name = "SqlServerBtnCreateFile";
            this.SqlServerBtnCreateFile.Size = new System.Drawing.Size(538, 23);
            this.SqlServerBtnCreateFile.TabIndex = 20;
            this.SqlServerBtnCreateFile.Text = "生成";
            this.SqlServerBtnCreateFile.UseVisualStyleBackColor = true;
            this.SqlServerBtnCreateFile.Click += new System.EventHandler(this.SqlServerBtnCreateFile_Click);
            // 
            // SqlServerCheckTypeScript
            // 
            this.SqlServerCheckTypeScript.AutoSize = true;
            this.SqlServerCheckTypeScript.Checked = true;
            this.SqlServerCheckTypeScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SqlServerCheckTypeScript.Location = new System.Drawing.Point(123, 76);
            this.SqlServerCheckTypeScript.Name = "SqlServerCheckTypeScript";
            this.SqlServerCheckTypeScript.Size = new System.Drawing.Size(84, 16);
            this.SqlServerCheckTypeScript.TabIndex = 8;
            this.SqlServerCheckTypeScript.Text = "TypeScript";
            this.SqlServerCheckTypeScript.UseVisualStyleBackColor = true;
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
            // SqlServerCheckCSharp
            // 
            this.SqlServerCheckCSharp.AutoSize = true;
            this.SqlServerCheckCSharp.Checked = true;
            this.SqlServerCheckCSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SqlServerCheckCSharp.Location = new System.Drawing.Point(81, 76);
            this.SqlServerCheckCSharp.Name = "SqlServerCheckCSharp";
            this.SqlServerCheckCSharp.Size = new System.Drawing.Size(36, 16);
            this.SqlServerCheckCSharp.TabIndex = 7;
            this.SqlServerCheckCSharp.Text = "C#";
            this.SqlServerCheckCSharp.UseVisualStyleBackColor = true;
            // 
            // SqlServerBtnBrowse
            // 
            this.SqlServerBtnBrowse.Location = new System.Drawing.Point(510, 47);
            this.SqlServerBtnBrowse.Name = "SqlServerBtnBrowse";
            this.SqlServerBtnBrowse.Size = new System.Drawing.Size(38, 23);
            this.SqlServerBtnBrowse.TabIndex = 6;
            this.SqlServerBtnBrowse.Text = "...";
            this.SqlServerBtnBrowse.UseVisualStyleBackColor = true;
            this.SqlServerBtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // SqlServerTextCreatePath
            // 
            this.SqlServerTextCreatePath.Location = new System.Drawing.Point(81, 47);
            this.SqlServerTextCreatePath.Name = "SqlServerTextCreatePath";
            this.SqlServerTextCreatePath.Size = new System.Drawing.Size(423, 21);
            this.SqlServerTextCreatePath.TabIndex = 5;
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
            // SqlServerTextProjectName
            // 
            this.SqlServerTextProjectName.Location = new System.Drawing.Point(81, 20);
            this.SqlServerTextProjectName.Name = "SqlServerTextProjectName";
            this.SqlServerTextProjectName.Size = new System.Drawing.Size(423, 21);
            this.SqlServerTextProjectName.TabIndex = 4;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 392);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SqlServer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MySql";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MySqlTextPort);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.MySqlTextPassword);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.MySqlTextAccount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.MySqlTextName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.MySqlTextAddress);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 163);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据库配置";
            // 
            // MySqlTextPort
            // 
            this.MySqlTextPort.Location = new System.Drawing.Point(94, 128);
            this.MySqlTextPort.Name = "MySqlTextPort";
            this.MySqlTextPort.Size = new System.Drawing.Size(100, 21);
            this.MySqlTextPort.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "数据库端口：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "数据库地址：";
            // 
            // MySqlTextPassword
            // 
            this.MySqlTextPassword.Location = new System.Drawing.Point(94, 101);
            this.MySqlTextPassword.Name = "MySqlTextPassword";
            this.MySqlTextPassword.Size = new System.Drawing.Size(100, 21);
            this.MySqlTextPassword.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "数据库名称：";
            // 
            // MySqlTextAccount
            // 
            this.MySqlTextAccount.Location = new System.Drawing.Point(94, 74);
            this.MySqlTextAccount.Name = "MySqlTextAccount";
            this.MySqlTextAccount.Size = new System.Drawing.Size(100, 21);
            this.MySqlTextAccount.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "数据库账号：";
            // 
            // MySqlTextName
            // 
            this.MySqlTextName.Location = new System.Drawing.Point(94, 47);
            this.MySqlTextName.Name = "MySqlTextName";
            this.MySqlTextName.Size = new System.Drawing.Size(100, 21);
            this.MySqlTextName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "数据库密码：";
            // 
            // MySqlTextAddress
            // 
            this.MySqlTextAddress.Location = new System.Drawing.Point(94, 20);
            this.MySqlTextAddress.Name = "MySqlTextAddress";
            this.MySqlTextAddress.Size = new System.Drawing.Size(100, 21);
            this.MySqlTextAddress.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MySqlBtnCreateFile);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.MySqlCheckCSharp);
            this.groupBox4.Controls.Add(this.MySqlBtnBrowse);
            this.groupBox4.Controls.Add(this.MySqlTextCreatePath);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.MySqlTextProjectName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(233, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 163);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "生成配置";
            // 
            // MySqlBtnCreateFile
            // 
            this.MySqlBtnCreateFile.Location = new System.Drawing.Point(6, 126);
            this.MySqlBtnCreateFile.Name = "MySqlBtnCreateFile";
            this.MySqlBtnCreateFile.Size = new System.Drawing.Size(538, 23);
            this.MySqlBtnCreateFile.TabIndex = 20;
            this.MySqlBtnCreateFile.Text = "生成";
            this.MySqlBtnCreateFile.UseVisualStyleBackColor = true;
            this.MySqlBtnCreateFile.Click += new System.EventHandler(this.MySqlBtnCreateFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "生成类型：";
            // 
            // MySqlCheckCSharp
            // 
            this.MySqlCheckCSharp.AutoSize = true;
            this.MySqlCheckCSharp.Checked = true;
            this.MySqlCheckCSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MySqlCheckCSharp.Location = new System.Drawing.Point(81, 76);
            this.MySqlCheckCSharp.Name = "MySqlCheckCSharp";
            this.MySqlCheckCSharp.Size = new System.Drawing.Size(36, 16);
            this.MySqlCheckCSharp.TabIndex = 7;
            this.MySqlCheckCSharp.Text = "C#";
            this.MySqlCheckCSharp.UseVisualStyleBackColor = true;
            // 
            // MySqlBtnBrowse
            // 
            this.MySqlBtnBrowse.Location = new System.Drawing.Point(510, 47);
            this.MySqlBtnBrowse.Name = "MySqlBtnBrowse";
            this.MySqlBtnBrowse.Size = new System.Drawing.Size(38, 23);
            this.MySqlBtnBrowse.TabIndex = 6;
            this.MySqlBtnBrowse.Text = "...";
            this.MySqlBtnBrowse.UseVisualStyleBackColor = true;
            // 
            // MySqlTextCreatePath
            // 
            this.MySqlTextCreatePath.Location = new System.Drawing.Point(81, 47);
            this.MySqlTextCreatePath.Name = "MySqlTextCreatePath";
            this.MySqlTextCreatePath.Size = new System.Drawing.Size(423, 21);
            this.MySqlTextCreatePath.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "生成位置：";
            // 
            // MySqlTextProjectName
            // 
            this.MySqlTextProjectName.Location = new System.Drawing.Point(81, 20);
            this.MySqlTextProjectName.Name = "MySqlTextProjectName";
            this.MySqlTextProjectName.Size = new System.Drawing.Size(423, 21);
            this.MySqlTextProjectName.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "项目名称：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体生成工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SqlServerTextAddress;
        private System.Windows.Forms.TextBox SqlServerTextName;
        private System.Windows.Forms.TextBox SqlServerTextAccount;
        private System.Windows.Forms.TextBox SqlServerTextPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SqlServerBtnCreateFile;
        private System.Windows.Forms.CheckBox SqlServerCheckTypeScript;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox SqlServerCheckCSharp;
        private System.Windows.Forms.Button SqlServerBtnBrowse;
        private System.Windows.Forms.TextBox SqlServerTextCreatePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SqlServerTextProjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox SqlServerCheckAngular;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox MySqlTextPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MySqlTextPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MySqlTextAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MySqlTextName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MySqlTextAddress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button MySqlBtnCreateFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox MySqlCheckCSharp;
        private System.Windows.Forms.Button MySqlBtnBrowse;
        private System.Windows.Forms.TextBox MySqlTextCreatePath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MySqlTextProjectName;
        private System.Windows.Forms.Label label14;
    }
}

