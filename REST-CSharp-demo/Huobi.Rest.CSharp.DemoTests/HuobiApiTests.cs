 using Huobi.Rest.CSharp.Demo;
using Huobi.Rest.CSharp.Demo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

//accessKey:  
//secretKey:  
namespace Huobi.Rest.CSharp.Demo.Tests
{
    [TestClass()]
    public class HuobiApiTests
    {
		//accessKey:  
		//secretKey: 
        HuobiApi api = new HuobiApi("XXXXXXXXXXX", "XXXXXXXXXXX");
        [TestMethod()]
        public void GetAllAccountTest()
        {
            var result = api.GetContractInfo();
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void OrderPlaceTest()
        {

            OrderPlaceRequest req = new OrderPlaceRequest();
            req.volume = 1;
            req.direction = "buy";
            req.price = 10;
            req.offset = "open";
            req.lever_rate = 10;
            req.order_price_type = "limit";
            var result = api.OrderPlace(req);
            Assert.AreEqual(result.Status, "ok");
        }

        [TestMethod()]
        public void OrderPositionTest()
        {

            OrderPositionRequest req = new OrderPositionRequest();
            req.symbol = "BTC";
            
            var result = api.OrderPosition(req);
            Assert.AreEqual(result.Status, "ok");
        }
    }
}