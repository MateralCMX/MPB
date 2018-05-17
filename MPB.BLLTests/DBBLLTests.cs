using Microsoft.VisualStudio.TestTools.UnitTesting;
using MPB.BLL;
using MPB.DAL;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPB.BLL.Tests
{
    [TestClass()]
    public class DBBLLTests
    {
        /// <summary>
        /// 数据库数据操作对象
        /// </summary>
        private readonly DBBLL _bll;
        public DBBLLTests()
        {
            DBDAL.connectionString = "Data Source=127.0.0.1;Initial Catalog=DZ_MAS;Persist Security Info=True;User ID=sa;Password=123456";
            _bll = new DBBLL();
        }
        [TestMethod()]
        public void GetUserCreateTableInfoTest()
        {
            List<TableModel> listM = _bll.GetUserCreateTableInfo();
            Assert.IsTrue(listM != null && listM.Count > 0);
        }

        [TestMethod()]
        public void CreateModelFilesTest()
        {
            DirectoryInfo di = new DirectoryInfo("D:\\Test");
            _bll.CreateModelFiles(di);
        }
    }
}