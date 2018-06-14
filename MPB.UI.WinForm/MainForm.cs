using MateralTools.MConvert;
using MateralTools.MIO;
using MateralTools.MVerify;
using MPB.BLL;
using MPB.DAL;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MPB.UI.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 控件加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region SqlServer
            SqlServerTextAddress.Text = "127.0.0.1";
            SqlServerTextAccount.Text = "sa";
            SqlServerTextPassword.Text = "123456";
            SqlServerTextName.Text = "BeiDouBMSDB";
            SqlServerTextProjectName.Text = "BeiDouBMS";
            #endregion
            #region MySql
            MySqlTextAddress.Text = "220.165.9.44";
            MySqlTextAccount.Text = "root";
            MySqlTextPassword.Text = "cmsserverv6";
            MySqlTextName.Text = "1010gps";
            MySqlTextProjectName.Text = "BeiDouBMS.TTX";
            MySqlTextPort.Text = "4311";
            #endregion
            #region 其他
            SqlServerTextCreatePath.Text = "E:\\Project\\Materal项目生成器\\Application\\Model";
            MySqlTextCreatePath.Text = "E:\\Project\\Materal项目生成器\\Application\\Model";
            #endregion
        }
        /// <summary>
        /// 浏览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = SqlServerTextCreatePath.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SqlServerTextCreatePath.Text = fbd.SelectedPath;
                MySqlTextCreatePath.Text = fbd.SelectedPath;
            }
        }
        /// <summary>
        /// SQLServer创建文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SqlServerBtnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                SqlServerBtnCreateFile.Text = "生成中....";
                SqlServerBtnCreateFile.Enabled = false;
                SqlServerBLL _bll = new SqlServerBLL();
                SqlServerDAL.connectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", SqlServerTextAddress.Text, SqlServerTextName.Text, SqlServerTextAccount.Text, SqlServerTextPassword.Text);
                SqlServerBLL.ProjectName = SqlServerTextProjectName.Text.Trim();
                List<SqlServerTableModel> listM = _bll.GetUserCreateTableInfo();
                string path = SqlServerTextCreatePath.Text;
                IOManager.DeleteDirectory(path);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                DirectoryInfo di = new DirectoryInfo(path);
                if (SqlServerCheckCSharp.Checked)
                {
                    _bll.CreateModelFilesByCSharp(listM, di);
                }
                if (SqlServerCheckTypeScript.Checked)
                {
                    _bll.CreateModelFilesByTypeScript(listM, di);
                }
                if (SqlServerCheckAngular.Checked)
                {
                    _bll.CreateModelFilesByAngular(listM, di);
                }
                MessageBox.Show("生成成功");
                IOManager.OpenExplorer(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlServerBtnCreateFile.Enabled = true;
                SqlServerBtnCreateFile.Text = "生成";
            }
        }
        /// <summary>
        /// MySql创建文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MySqlBtnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string portStr = MySqlTextPort.Text.Trim();
                int port = 0;
                if (portStr.MIsNumber())
                {
                    MySqlBtnCreateFile.Text = "生成中....";
                    MySqlBtnCreateFile.Enabled = false;
                    string address = MySqlTextAddress.Text.Trim();
                    port = Convert.ToInt32(portStr);
                    string account = MySqlTextAccount.Text.Trim();
                    string password = MySqlTextPassword.Text.Trim();
                    string dbName = MySqlTextName.Text.Trim();
                    MySqlBLL _bll = new MySqlBLL(address, dbName, account, password, port);
                    MySqlBLL.ProjectName = MySqlTextProjectName.Text.Trim();
                    List<MySqlTableModel> listM = _bll.GetUserCreateTableInfo();
                    string path = MySqlTextCreatePath.Text;
                    IOManager.DeleteDirectory(path);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    DirectoryInfo di = new DirectoryInfo(path);
                    if (MySqlCheckCSharp.Checked)
                    {
                        _bll.CreateModelFilesByCSharp(listM, di);
                    }
                    MessageBox.Show("生成成功");
                    IOManager.OpenExplorer(path);
                }
                else
                {
                    MessageBox.Show("端口号必须为数字");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MySqlBtnCreateFile.Enabled = true;
                MySqlBtnCreateFile.Text = "生成";
            }
        }
    }
}
