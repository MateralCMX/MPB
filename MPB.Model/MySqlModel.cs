using MateralTools.MData;
using System.Collections.Generic;

namespace MPB.Model
{
    /// <summary>
    /// 表模型
    /// </summary>
    public class MySqlTableModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        [MColumnModel("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [MColumnModel("Remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 所拥有的列
        /// </summary>
        public List<MySqlColumnModel> Columns { get; set; }
    }
    /// <summary>
    /// 列模型
    /// </summary>
    public class MySqlColumnModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        [MColumnModel("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [MColumnModel("Remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        [MColumnModel("DataType")]
        public string DataType { get; set; }
        /// <summary>
        /// 是否为主键
        /// </summary>
        [MColumnModel("ColumKey")]
        public string ColumKey { get; set; }
        /// <summary>
        /// 是否为空
        /// </summary>
        [MColumnModel("IsNull")]
        public string IsNull { get; set; }
        /// <summary>
        /// 类型-C#
        /// </summary>
        public string TypeByCSharp
        {
            get
            {
                string typeInfo = null;
                switch (DataType)
                {
                    case "tinyint":
                        typeInfo = IsNull == "YES" ? "byte?" : "byte";
                        break;
                    case "smallint":
                        typeInfo = IsNull == "YES" ? "short?" : "short";
                        break;
                    case "int":
                        typeInfo = IsNull == "YES" ? "int?" : "int";
                        break;
                    case "bigint":
                        typeInfo = IsNull == "YES" ? "long?" : "long";
                        break;
                    case "real":
                    case "smallmoney":
                    case "money":
                    case "float":
                        typeInfo = IsNull == "YES" ? "float?" : "float";
                        break;
                    case "double":
                        typeInfo = IsNull == "YES" ? "double?" : "double";
                        break;
                    case "decimal":
                    case "numeric":
                        typeInfo = IsNull == "YES" ? "decimal?" : "decimal";
                        break;
                    case "nchar":
                    case "ntext":
                    case "text":
                    case "varchar":
                    case "char":
                    case "nvarchar":
                        typeInfo = "string";
                        break;
                    case "bit":
                        typeInfo = "bool";
                        break;
                    case "date":
                    case "datetime":
                    case "datetime2":
                    case "smalldatetime":
                    case "time":
                    case "timestamp":
                        typeInfo = IsNull == "YES" ? "DateTime?" : "DateTime";
                        break;
                    case "datetimeoffset":
                        typeInfo = IsNull == "YES" ? "DateTimeOffset?" : "DateTimeOffset";
                        break;
                    case "sql_variant":
                        typeInfo = "object";
                        break;
                    case "varbinary":
                    case "image":
                    case "binary":
                        typeInfo = "byte[]";
                        break;
                    case "uniqueidentifier":
                        typeInfo = IsNull == "YES" ? "Guid?" : "Guid";
                        break;
                    case "xml":
                        typeInfo = "XmlDocument";
                        break;
                }
                return typeInfo;
            }
        }
        /// <summary>
        /// 类型-TypeScript
        /// </summary>
        public string TypeByTypeScript
        {
            get
            {
                string typeInfo = null;
                switch (DataType)
                {
                    case "bit":
                        typeInfo = "boolean";
                        break;
                    case "int":
                    case "float":
                    case "decimal":
                    case "bigint":
                    case "tinyint":
                    case "money":
                    case "numeric":
                    case "real":
                    case "smallint":
                    case "smallmoney":
                        typeInfo = "number";
                        break;
                    case "image":
                    case "timestamp":
                    case "varbinary":
                    case "binary":
                        typeInfo = "Array<number>";
                        break;
                    case "date":
                    case "datetime":
                    case "datetime2":
                    case "datetimeoffset":
                    case "smalldatetime":
                    case "time":
                        typeInfo = "Date";
                        break;
                    case "sql_variant":
                        typeInfo = "any";
                        break;
                    case "xml":
                    case "varchar":
                    case "uniqueidentifier":
                    case "text":
                    case "char":
                    case "nchar":
                    case "ntext":
                    case "nvarchar":
                        typeInfo = "string";
                        break;
                }
                return typeInfo;
            }
        }
    }
}
