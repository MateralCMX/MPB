using MateralTools.MIO;
using MPB.BLL;
using MPB.DAL;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// 浏览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = TextCreatePath.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextCreatePath.Text = fbd.SelectedPath;
            }
        }
        /// <summary>
        /// 创建文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                BtnCreateFile.Text = "生成中....";
                BtnCreateFile.Enabled = false;
                DBBLL _bll = new DBBLL();
                DBDAL.connectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", TextDBAddress.Text, TextDBName.Text, TextDBAccount.Text, TextDBPassword.Text);
                DBBLL.ProjectName = TextProjectName.Text.Trim();
                List<TableModel> listM = _bll.GetUserCreateTableInfo();
                string path = TextCreatePath.Text;
                IOManager.DeleteDirectory(path);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                DirectoryInfo di = new DirectoryInfo(path);
                if (CheckCSharp.Checked)
                {
                    _bll.CreateModelFilesByCSharp(listM, di);
                }
                if (CheckTypeScript.Checked)
                {
                    _bll.CreateModelFilesByTypeScript(listM, di);
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
                BtnCreateFile.Enabled = true;
                BtnCreateFile.Text = "生成";
            }
        }
    }
}
