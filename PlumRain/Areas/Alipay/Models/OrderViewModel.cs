using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlumRain.Areas.Alipay.Models
{
    public class OrderViewModel
    {
        /// <summary>
        /// 接口名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 商家身份ID
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// 商家支付宝账号
        /// </summary>
        public string SellerAccount { get; set; }


        /// <summary>
        /// 签名方式
        /// </summary>
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单名称
        /// </summary>
        public string OrderName { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public string OrderValue { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        public string OrderDescription { get; set; }

        /// <summary>
        /// 订单展示地址
        /// </summary>
        public string OrderShowUrl { get; set; }


    }
}