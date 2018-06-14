using MateralTools.MConvert;
using MPB.Common;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPB.DAL
{
    public class MySqlDAL
    {
        /// <summary>
        /// 数据库帮助对象
        /// </summary>
        private readonly MysqlHelper _Helper;
        /// <summary>
        /// 数据库名称
        /// </summary>
        private readonly string _dbName;
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="address">服务器地址</param>
        /// <param name="dbName">数据库名称</param>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <param name="port">端口</param>
        public MySqlDAL(string address, string dbName, string account, string password, int port)
        {
            _Helper = new MysqlHelper(address, dbName, account, password, port);
            _dbName = dbName;
        }
        /// <summary>
        /// 获得用户创建的表信息
        /// </summary>
        /// <returns>用户所创建的表列表</returns>
        public List<MySqlTableModel> GetUserCreateTableInfo()
        {
            string sqlStr = String.Format("SELECT table_name as 'Name',TABLE_COMMENT as 'Remark' FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE' and table_schema = '{0}'", _dbName);
            DataTable dt = _Helper.ExecuteDataTable(sqlStr);
            List<MySqlTableModel> listM = dt.MToList<MySqlTableModel>(true);
            return listM;
        }
        /// <summary>
        /// 获得表列信息
        /// </summary>
        /// <param name="id">表的ID</param>
        /// <returns>列列表</returns>
        public List<MySqlColumnModel> GetTableColumnInfoByTableName(string name)
        {
            string sqlStr = String.Format("SELECT COLUMN_NAME as 'Name', IS_NULLABLE as 'IsNull', DATA_TYPE as 'DataType', COLUMN_KEY as 'ColumKey', COLUMN_COMMENT as 'Remark' FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}'", name);
            DataTable dt = _Helper.ExecuteDataTable(sqlStr);
            List<MySqlColumnModel> listM = dt.MToList<MySqlColumnModel>(true);
            return listM;
        }
    }
}
