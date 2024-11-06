using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1736
{
    /// <summary>
    /// 所有區域
    /// </summary>
    public class AllType
    {
        /// <summary>
        /// 搜尋資訊區
        /// </summary>
        public Search SearchInformation { get; set; }
        /// <summary>
        /// 交易訊息區
        /// </summary>
        public TradeInformation TradeInformation { get; set; }
        /// <summary>
        /// 投資人擔保品清單區
        /// </summary>
        public List<PurchasedCollateralList> List { get; set; }
     
    }
}
