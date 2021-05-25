using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseFormsApp.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseFormsApp.Tests.Utils
{
    [TestClass]
    public class LogUtilTest
    {
        [TestMethod]
        public void ConsoleWriteLineWithInfoLogMethod()
        {
            var logUtil = new LogUtil();
            logUtil.ConsoleWriteLineWithInfoLog("error");
        }
    }
}
