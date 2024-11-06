using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDemo2_1736
{
    /// <summary>
    /// 交易資訊區
    /// </summary>
    public class TradeInformation
    {
        /// <summary>
        /// 投資人帳號
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 擔保日期
        /// </summary>
        public string GuaranteeDate { get; set; }
        /// <summary>
        /// 擔保日期-序號
        /// </summary>       
        public int GuaranteeDatId { get; set; }
        /// <summary>
        /// 委託日期
        /// </summary>
        public string OrderDate { get; set; }
      
        /// <summary>
        /// 委託日期-序號
        /// </summary>
        public int OrderDateId { get; set; }
        /// <summary>
        /// 已申報擔保總金額
        /// </summary>
        public  int ReportedTotalMoney { get; set; }
        /// <summary>
        /// 擔保維持
        /// </summary>
         [JsonIgnore]
        public string CollateralMaintenanceRatio { get; set; }
        /// <summary>
        /// 擔保維持率
        /// </summary>
        public string CollateralMaintenancePercentage { get { return $"{CollateralMaintenanceRatio}%"; } }
        /// <summary>
        /// 比率總值
        /// </summary>
        public int TotalRatioValue { get; set; }
        /// <summary>
        /// 功能碼
        /// </summary>
        public string FunctionCode { get; set; }
        /// <summary>
        /// 成交狀態
        /// </summary>
        public string TradeStatus { get; set; }
        /// <summary>
        /// 還券狀態
        /// </summary>
        public string SecuritiesReturnStatus { get; set; }
        /// <summary>
        /// 交易資訊明細
        /// </summary>
        public List<CollateralDetails> CollateralDetailsInfo { get; set; }
    }
}
