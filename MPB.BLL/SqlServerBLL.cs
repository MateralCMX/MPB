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
    public class SqlServerBLL
    {
        /// <summary>
        /// 数据操作类
        /// </summary>
        private readonly SqlServerDAL _dal;
        /// <summary>
        /// 项目名称
        /// </summary>
        public static string ProjectName = "MateralProject";
        /// <summary>
        /// 构造方法
        /// </summary>
        public SqlServerBLL()
        {
            _dal = new SqlServerDAL();
        }
        /// <summary>
        /// 获得所有用户自定义表信息
        /// </summary>
        /// <returns></returns>
        public List<SqlServerTableModel> GetUserCreateTableInfo()
        {
            List<SqlServerTableModel> listM = _dal.GetUserCreateTableInfo();
            for (int i = 0; i < listM.Count; i++)
            {
                listM[i].Columns = _dal.GetTableColumnInfoByTableID(listM[i].ID);
            }
            return listM;
        }
        #region C#
        /// <summary>
        /// 获得模型代码字符串
        /// </summary>
        /// <param name="tableModel">表模型</param>
        /// <returns>模型代码字符串</returns>
        public string GetModelCodeStrByCSharp(SqlServerTableModel tableModel)
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
                List<SqlServerColumnModel> PKitems = tableModel.Columns.Where(m => m.IsPK == 1).ToList();
                if (PKitems == null || PKitems.Count == 0)
                {
                    tableModel.Columns[0].IsPK = 1;
                }
                foreach (SqlServerColumnModel item in tableModel.Columns)
                {
                    if (!item.Remark.MIsNullOrEmpty())
                    {
                        code += "        /// <summary>\r\n";
                        code += String.Format("        /// {0}\r\n", item.Remark);
                        code += "        /// </summary>\r\n";
                        code += String.Format("        [Description(\"{0}\")]\r\n", item.Remark);
                    }
                    code += String.Format("        [Column(\"{0}\")]\r\n", item.Name);
                    if (item.IsPK == 1)
                    {
                        code += "        [Key]\r\n";
                    }
                    if (item.DataType == "timestamp")
                    {
                        code += "        [Timestamp]\r\n";
                    }
                    else if (item.IsNull == 0 && item.IsPK == 0)
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
        public void CreateModelFilesByCSharp(List<SqlServerTableModel> listM, DirectoryInfo di)
        {
            string code = "";
            byte[] codeBytes;
            string path = di.FullName + "\\SqlServer\\C#";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            foreach (SqlServerTableModel item in listM)
            {
                path = di.FullName + "\\SqlServer\\C#\\" + item.Name + ".cs";
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
        #region TypeScript
        /// <summary>
        /// 获得模型代码字符串
        /// </summary>
        /// <param name="tableModel">表模型</param>
        /// <returns>模型代码字符串</returns>
        public string GetModelCodeStrByTypeScript(SqlServerTableModel tableModel)
        {
            string code = string.Empty;
            if (!tableModel.Remark.MIsNullOrEmpty())
            {
                code += "    /**\r\n";
                code += String.Format("     * {0}\r\n", tableModel.Remark);
                code += "     */\r\n";
            }
            code += String.Format("    export class {0} ", tableModel.Name) + "{\r\n";
            if (tableModel.Columns != null && tableModel.Columns.Count > 0)
            {
                SqlServerColumnModel PKitem = tableModel.Columns.Where(m => m.IsPK == 1).FirstOrDefault();
                if (PKitem == null)
                {
                    tableModel.Columns[0].IsPK = 1;
                }
                foreach (SqlServerColumnModel item in tableModel.Columns)
                {
                    if (!item.Remark.MIsNullOrEmpty())
                    {
                        code += "    /**\r\n";
                        code += String.Format("     * {0}\r\n", item.Remark);
                        code += "     */\r\n";
                    }
                    code += String.Format("        public {0}: {1}", item.Name, item.TypeByTypeScript);
                    if (item.TypeByCSharp == "Guid")
                    {
                        code += "=\"" + Guid.Empty.ToString() + "\";\r\n";
                    }
                    else
                    {
                        code += ";\r\n";
                    }
                }
            }
            code += "    }\r\n";
            return code;
        }
        /// <summary>
        /// 创建TypeScripg模型文件
        /// </summary>
        /// <param name="listM">表列表</param>
        /// <param name="di">父级目录</param>
        public void CreateModelFilesByTypeScript(List<SqlServerTableModel> listM, DirectoryInfo di)
        {
            string code = "";
            code += "'use strict';\r\n";
            code += String.Format("namespace {0}.Model", ProjectName) + "{\r\n";
            string path = di.FullName + "\\SqlServer\\TypeScript";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += string.Format("\\{0}Model.ts", ProjectName);
            foreach (SqlServerTableModel item in listM)
            {
                code += GetModelCodeStrByTypeScript(item);
            }
            code += "}\r\n";
            byte[] codeBytes = Encoding.UTF8.GetBytes(code);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream sr = File.Create(path))
            {
                sr.Write(codeBytes, 0, codeBytes.Length - 1);
            }
        }
        #endregion
        #region Angular
        public void CreateModelFilesByAngular(List<SqlServerTableModel> listM, DirectoryInfo di)
        {
            string code = "";
            byte[] codeBytes;
            string path = di.FullName + "\\SqlServer\\Angular";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            foreach (SqlServerTableModel item in listM)
            {
                path = di.FullName + "\\SqlServer\\Angular\\" + item.Name + ".ts";
                code = GetModelCodeStrByTypeScript(item);
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
