using MateralTools.MData;
using System.Collections.Generic;

namespace MPB.Model
{
    /// <summary>
    /// 表模型
    /// </summary>
    public class TableModel
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        [MColumnModel("ID")]
        public int ID { get; set; }
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
        public List<ColumnModel> Columns { get; set; }
    }
    /// <summary>
    /// 列模型
    /// </summary>
    public class ColumnModel
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
        [MColumnModel("Types")]
        public string Types { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        [MColumnModel("Length")]
        public short Length { get; set; }
        /// <summary>
        /// 是否为主键
        /// </summary>
        [MColumnModel("IsPK")]
        public int IsPK { get; set; }
        /// <summary>
        /// 是否为空
        /// </summary>
        [MColumnModel("IsNull")]
        public int IsNull { get; set; }
        /// <summary>
        /// 类型-C#
        /// </summary>
        public string TypeByCSharp
        {
            get
            {
                string typeInfo = null;
                switch (Types)
                {
                    case "tinyint":
                        typeInfo = IsNull == 1 ? "byte?" : "byte";
                        break;
                    case "smallint":
                        typeInfo = IsNull == 1 ? "short?" : "short";
                        break;
                    case "int":
                        typeInfo = IsNull == 1 ? "int?" : "int";
                        break;
                    case "bigint":
                        typeInfo = IsNull == 1 ? "long?" : "long";
                        break;
                    case "real":
                    case "smallmoney":
                    case "money":
                        typeInfo = IsNull == 1 ? "float?" : "float";
                        break;
                    case "float":
                        typeInfo = IsNull == 1 ? "double?" : "double";
                        break;
                    case "decimal":
                    case "numeric":
                        typeInfo = IsNull == 1 ? "decimal?" : "decimal";
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
                        typeInfo = IsNull == 1 ? "DateTime?" : "DateTime";
                        break;
                    case "datetimeoffset":
                        typeInfo = IsNull == 1 ? "DateTimeOffset?" : "DateTimeOffset";
                        break;
                    case "sql_variant":
                        typeInfo = "object";
                        break;
                    case "varbinary":
                    case "timestamp":
                    case "image":
                    case "binary":
                        typeInfo = "byte[]";
                        break;
                    case "uniqueidentifier":
                        typeInfo = IsNull == 1 ? "Guid?" : "Guid";
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
                switch (Types)
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
