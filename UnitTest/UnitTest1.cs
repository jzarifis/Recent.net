using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecentLib;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var lib = new RecentCore();
            var wallet = lib.importWalletFromSeedPhrase("combine close before lawsuit asthma glimpse yard debate mixture stool adjust ride");
            //Parallel.For(0, 100, i =>
            //{
            //    var l = lib.addRelayer($"https://2.google.com.{i}", "2.Google.{i}", true, 0.1m, false, null).Result;

            //});
            //for (int i = 0; i < 10; i++)
            //{
            //    var l = lib.addRelayer($"https://www.google.com.{i}", "Google.{i}", true, 0.1m, false, null).Result;
            //}

            //var r11 = lib.addRelayer("https://www.google.com1", "Google1", true, 0.1m, false, null).Result;
            //var r12 = lib.addRelayer("https://www.google.com2", "Google1", true, 0.1m, false, null).Result;

            //var r2 = lib.getRelayer("https://www.google.com1").Result;

            var r3 = lib.getRelayers().Result;

        }
    }
}
