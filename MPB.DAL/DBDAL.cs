using MPB.Commone;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MateralTools.MConvert;

namespace MPB.DAL
{
    /// <summary>
    /// 数据库数据操作类
    /// </summary>
    public class DBDAL
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string connectionString = "Data Source=127.0.0.1;Initial Catalog=RTPay;Persist Security Info=True;User ID=sa;Password=123456";
        /// <summary>
        /// 获得用户创建的表信息
        /// </summary>
        /// <returns>用户所创建的表列表</returns>
        public List<TableModel> GetUserCreateTableInfo()
        {
            string sqlStr = "select t1.ID,t1.Name,t2.Remark from(select id as 'ID',sysobjects.name as 'Name' from sysobjects where xtype in ('U','V') and sysobjects.name <> 'sysdiagrams') as t1 left join(select major_id as 'ID',value as 'Remark' from sys.extended_properties as ex_p where ex_p.minor_id=0 and ex_p.name = 'MS_Description') as t2 on t1.ID = t2.ID";
            DataSet ds = new DataSet();
            SqlServerHelper.FillDataset(connectionString, CommandType.Text, sqlStr, ds, null);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                List<TableModel> listM = dt.MToList<TableModel>(true);
                return listM;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得表列信息
        /// </summary>
        /// <param name="id">表的ID</param>
        /// <returns>列列表</returns>
        public List<ColumnModel> GetTableColumnInfoByTableID(long id)
        {
            string sqlStr = $"SELECT col.name AS 'Name',ISNULL(ep.[value], NULL) AS 'Remark',t.name AS 'Types', t.length as 'Length', CASE WHEN EXISTS(SELECT 1 FROM dbo.sysindexes si INNER JOIN dbo.sysindexkeys sik ON si.id = sik.id AND si.indid = sik.indid INNER JOIN dbo.syscolumns sc ON sc.id = sik.id AND sc.colid = sik.colid INNER JOIN dbo.sysobjects so ON so.name = si.name AND so.xtype = 'PK' WHERE sc.id = col.id AND sc.colid = col.colid ) THEN 1 ELSE 0 END AS 'IsPK', CASE WHEN col.isnullable = 1 THEN 1 ELSE 0 END AS 'IsNull' FROM dbo.syscolumns col LEFT  JOIN dbo.systypes t ON col.xtype = t.xusertype inner JOIN dbo.sysobjects obj ON col.id = obj.id AND obj.xtype in ('U','V') AND obj.status >= 0 LEFT  JOIN dbo.syscomments comm ON col.cdefault = comm.id LEFT  JOIN sys.extended_properties ep ON col.id = ep.major_id AND col.colid = ep.minor_id AND ep.name = 'MS_Description' LEFT  JOIN sys.extended_properties epTwo ON obj.id = epTwo.major_id AND epTwo.minor_id = 0 AND epTwo.name = 'MS_Description' WHERE obj.id = {id}";
            DataSet ds = new DataSet();
            SqlServerHelper.FillDataset(connectionString, CommandType.Text, sqlStr, ds, null);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                List<ColumnModel> listM = dt.MToList<ColumnModel>(true);
                return listM;
            }
            else
            {
                return null;
            }
        }
    }
}
