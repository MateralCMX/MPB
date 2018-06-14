using MateralTools.MVerify;
using MPB.DAL;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPB.BLL
{
    public class MySqlBLL
    {
        /// <summary>
        /// 数据操作类
        /// </summary>
        private readonly MySqlDAL _dal;
        /// <summary>
        /// 项目名称
        /// </summary>
        public static string ProjectName = "MateralProject";
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="address">服务器地址</param>
        /// <param name="dbName">数据库名称</param>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <param name="port">端口</param>
        public MySqlBLL(string address, string dbName, string account, string password, int port)
        {
            _dal = new MySqlDAL(address, dbName, account, password, port);
        }
        /// <summary>
        /// 获得所有用户自定义表信息
        /// </summary>
        /// <returns></returns>
        public List<MySqlTableModel> GetUserCreateTableInfo()
        {
            List<MySqlTableModel> listM = _dal.GetUserCreateTableInfo();
            for (int i = 0; i < listM.Count; i++)
            {
                listM[i].Columns = _dal.GetTableColumnInfoByTableName(listM[i].Name);
            }
            return listM;
        }
        #region C#
        /// <summary>
        /// 获得模型代码字符串
        /// </summary>
        /// <param name="tableModel">表模型</param>
        /// <returns>模型代码字符串</returns>
        public string GetModelCodeStrByCSharp(MySqlTableModel tableModel)
        {
            string code = string.Empty;
            code += "using System;\r\n";
            code += "using System.ComponentModel;\r\n";
            code += "using System.ComponentModel.DataAnnotations;\r\n";
            code += "using System.ComponentModel.DataAnnotations.Schema;\r\n";
            code += "using MateralTools.MEntityFramework;\r\n";
            code += String.Format("namespace {0}.Model\r\n", ProjectName);
            code += "{\r\n";
            if (!tableModel.Remark.MIsNullOrEmpty())
            {
                code += "    /// <summary>\r\n";
                code += String.Format("    /// {0}\r\n", tableModel.Remark);
                code += "    /// </summary>\r\n";
            }
            code += String.Format("    [Table(\"{0}\")]\r\n", tableModel.Name);
            code += String.Format("    public class {0}\r\n", tableModel.Name);
            code += "    {\r\n";
            if (tableModel.Columns != null && tableModel.Columns.Count > 0)
            {
                List<MySqlColumnModel> PKitems = tableModel.Columns.Where(m => m.ColumKey == "PRI").ToList();
                if (PKitems == null || PKitems.Count == 0)
                {
                    tableModel.Columns[0].ColumKey = "PRI";
                }
                foreach (MySqlColumnModel item in tableModel.Columns)
                {
                    if (!item.Remark.MIsNullOrEmpty())
                    {
                        code += "        /// <summary>\r\n";
                        code += String.Format("        /// {0}\r\n", item.Remark);
                        code += "        /// </summary>\r\n";
                        code += String.Format("        [Description(\"{0}\")]\r\n", item.Remark);
                    }
                    code += String.Format("        [Column(\"{0}\")]\r\n", item.Name);
                    if (item.ColumKey == "PRI")
                    {
                        code += "        [Key]\r\n";
                    }
                    if (item.DataType == "timestamp")
                    {
                        code += "        [Timestamp]\r\n";
                    }
                    else if (item.IsNull == "NO" && item.ColumKey != "PRI")
                    {
                        code += "        [Required]\r\n";
                    }
                    if (item.Name == "IsDelete")
                    {
                        code += "        [LogicDelete]\r\n";
                    }
                    //if (item.TypeByCSharp == "string")
                    //{
                    //    code += string.Format("        [MaxLength({0})]\r\n", item.Length);
                    //}
                    code += String.Format("        public {0} {1} ", item.TypeByCSharp, item.Name) + "{ get; set; }\r\n";
                }
            }
            code += "    }\r\n";
            code += "}\r\n";
            return code;
        }
        /// <summary>
        /// 创建C#模型文件
        /// </summary>
        /// <param name="listM">表列表</param>
        /// <param name="di">父级目录</param>
        public void CreateModelFilesByCSharp(List<MySqlTableModel> listM, DirectoryInfo di)
        {
            string code = "";
            byte[] codeBytes;
            string path = di.FullName + "\\MySql\\C#";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            foreach (MySqlTableModel item in listM)
            {
                path = di.FullName + "\\MySql\\C#\\" + item.Name + ".cs";
                code = GetModelCodeStrByCSharp(item);
                codeBytes = Encoding.UTF8.GetBytes(code);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream sr = File.Create(path))
                {
                    sr.Write(codeBytes, 0, codeBytes.Length - 1);
                }
            }
        }
        #endregion
    }
}
