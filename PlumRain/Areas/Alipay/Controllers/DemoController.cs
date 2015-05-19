using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Com.Alipay;
using PlumRain.Areas.Alipay.Models;

namespace PlumRain.Areas.Alipay.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Alipay/Demo/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OrderViewModel order)
        {
            Config.Partner = order.Partner;
            Config.Seller_email = order.SellerAccount;

            //把请求参数打包成数组
            var sParaTemp = new SortedDictionary<string, string>
            {
                {"partner", Config.Partner},
                {"seller_email", Config.Seller_email},
                {"_input_charset", Config.Input_charset.ToLower()},
                {"service", "create_direct_pay_by_user"},
                {"payment_type", "1"},
                {"notify_url", "http://plumrain.cn/Alipay/Demo"},
                {"return_url", "http://plumrain.cn"},
                {"out_trade_no", order.OrderNo},
                {"subject", order.OrderName},
                {"total_fee", order.OrderValue},
                {"body", order.OrderDescription},
                {"show_url", order.OrderShowUrl},
                {"anti_phishing_key", ""},
                {"exter_invoke_ip", ""}
            };
            string sHtmlText = Submit.BuildRequest(sParaTemp, "get", "确认");
            Response.Write(sHtmlText);
            return View();
        }
    }
}