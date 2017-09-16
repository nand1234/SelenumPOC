using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.OleDb;
using AventStack.ExtentReports;
using NUnit.Compatibility;
using System.IO;

namespace VievU
{
    [TestClass]
    public class TestCase 
    {
        
        private TestContext testContextInstance;
        protected static ExtentReports extent;
        protected static ExtentTest test;
        private  static AventStack.ExtentReports.Reporter.ExtentHtmlReporter htmlReporter;
     
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassInitialize]
        public static void Initializereport(TestContext context)
        {
               //Added Code
                htmlReporter = new AventStack.ExtentReports.Reporter.ExtentHtmlReporter("D:\\Automation - Doc\\Vievuautomationresult.html");
                htmlReporter.LoadConfig("Extendreport.xml");
                extent = new ExtentReports();
               extent.AddSystemInfo("Host Name", "Nandkumar");
               extent.AddSystemInfo("Environment", "QA");
               extent.AddSystemInfo("User Name", "Nandkumar");
                extent.AttachReporter(htmlReporter);
           
        }


       [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Data.csv", "Data#csv", DataAccessMethod.Sequential), TestMethod]
        public void AddCase()
        {
            var Module = TestContext.DataRow["Module"].ToString();
            var Submodule = TestContext.DataRow["Submodule"].ToString();
            var Testcase = TestContext.DataRow["Test Case"].ToString();
            var Username = TestContext.DataRow["UserName"].ToString();
            var Password = TestContext.DataRow["Password"].ToString();
            var inputdata = TestContext.DataRow["InputData"].ToString();
            var Actualresult = TestContext.DataRow["Actual result"].ToString();
            var Expectedresult = TestContext.DataRow["Expected result"].ToString();
            var Status = TestContext.DataRow["Status"].ToString();
            var Testcasetype = TestContext.DataRow["Test Case Type"].ToString();
            var test = extent.CreateTest("Test1");
            test.Log(AventStack.ExtentReports.Status.Info, "inputdata(Username, Password)");
            test.Log(AventStack.ExtentReports.Status.Pass, "Test Passed");
            test.Log(AventStack.ExtentReports.Status.Fail, "Test fail");
            test.Log(AventStack.ExtentReports.Status.Fatal, "Test Fatal");
            test.Log(AventStack.ExtentReports.Status.Pass, "Test Passed");
            extent.Flush();
            
            //DBConnection.Dbconnection.connectdb(Module, Submodule, Testcase, Username, Password, inputdata, Actualresult, Expectedresult, Status, Testcasetype);

        }
        
        [TestMethod]
        public void Emailresult()
        {
           
            Email.Email.Sendemail();
        }

    }
}
