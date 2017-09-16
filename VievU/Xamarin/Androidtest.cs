using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Utils;


namespace VievU.Xamarin
{
    [TestClass]
    public class Androidtest
    {
        AndroidApp App;
        
        public void TestMethod1()
        {
            
            App.Repl();
        }
    }
}
