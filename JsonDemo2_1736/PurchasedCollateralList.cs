using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1736
{
    /// <summary>
    /// 投資人購買擔保品清單
    /// </summary>
    public class PurchasedCollateralList
    {
        /// <summary>
        /// 投資人帳號
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 擔保品序號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
    }
}
