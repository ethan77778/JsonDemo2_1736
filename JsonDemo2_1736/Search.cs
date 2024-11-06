using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1736
{
    /// <summary>
    /// 搜尋區
    /// </summary>
    public class Search
    {
        /// <summary>
        /// 擔保品日期
        /// </summary>
        public string CollateralDate { get; set; }
        /// <summary>
        /// 投資人帳號
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 成交狀態
        /// </summary>
       public string TransactionStatus { get; set; }
        /// <summary>
        /// 還券狀態
        /// </summary>
        public string SecuritiesReturnStatus { get; set; }
    }
}
