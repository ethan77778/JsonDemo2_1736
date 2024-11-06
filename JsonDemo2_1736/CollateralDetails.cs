using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1736
{
    /// <summary>
    /// 擔保品明細
    /// </summary>
    public class CollateralDetails
    {
        /// <summary>
        /// 擔保品日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 擔保品序號
        /// </summary>
        public string CollateralSerialNumber { get; set; }
        /// <summary>
        /// 擔保種類
        /// </summary>
        public string CollateralType { get; set; }
        /// <summary>
        /// 銀行保證序號
        /// </summary>
        public string BankSerialNumber { get; set; }
        /// <summary>
        /// 證券來源-券商
        /// </summary>
        public string SBroker { get; set; }
        /// <summary>
        /// 證券來源-帳號
        /// </summary>
        public string SourceAccount { get; set; }
        /// <summary>
        /// 異動數量
        /// </summary>
        public string ChangedQuantity { get; set; }
    }
}
