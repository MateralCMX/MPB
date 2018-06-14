using Microsoft.VisualStudio.TestTools.UnitTesting;
using MPB.DAL;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPB.DAL.Tests
{
    [TestClass()]
    public class MySqlDALTests
    {
        /// <summary>
        /// 数据库数据操作对象
        /// </summary>
        private readonly MySqlDAL _dal;
        public MySqlDALTests()
        {
            string address = "220.165.9.44";
            int port = 4311;
            string account = "root";
            string password = "cmsserverv6";
            string dbName = "1010gps";
            _dal = new MySqlDAL(address, dbName, account, password, port);
        }
        [TestMethod()]
        public void GetUserCreateTableInfoTest()
        {
            List<MySqlTableModel> listM = _dal.GetUserCreateTableInfo();
            Assert.IsTrue(listM != null && listM.Count > 0);
        }
        [TestMethod()]
        public void GetTableColumnInfoByTableNameTest()
        {
            List<MySqlColumnModel> listM = _dal.GetTableColumnInfoByTableName("jt808_company_info");
            Assert.IsTrue(listM != null && listM.Count > 0);
        }
    }
}