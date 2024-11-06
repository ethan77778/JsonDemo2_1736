using Newtonsoft.Json;

namespace JsonDemo2_1736
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var All = new AllType 
            {
                SearchInformation=new Search 
                {
                    CollateralDate="2024/09/05",
                    Account="1234567",
                    TransactionStatus="成功",
                    SecuritiesReturnStatus="已還券"
                },
                TradeInformation=new TradeInformation
                {
                    Account="1234567",
                    GuaranteeDate="2024/09/05",
                    GuaranteeDatId = 2,
                    OrderDate="2024/08/22",
                    OrderDateId = 2,
                    ReportedTotalMoney=70000,
                    CollateralMaintenanceRatio="110",
                    TotalRatioValue=10,
                    FunctionCode="I",
                    TradeStatus="成功",
                    SecuritiesReturnStatus="已還券"
                },
                List=new List<PurchasedCollateralList>
                {
                    new PurchasedCollateralList
                    {
                        Account="1234567",
                        Id=2,
                        Date="20240905"
                    },
                    new PurchasedCollateralList
                    {
                        Account="4162678",
                        Id=3,
                        Date="20240905"
                    },
                    new PurchasedCollateralList
                    {
                        Account="4005188",
                        Id=4,
                        Date="20240905"
                    }
                },
                CollateralInformation=new List<CollateralDetails>
                {
                    new CollateralDetails
                    {
                        Date="2024/09/05",
                        CollateralSerialNumber="2",
                        CollateralType="現金",
                        BankSerialNumber="50677",
                        SBroker=" HSBC",
                        SourceAccount="012",
                        ChangedQuantity="50"
                    }
                }
            };
            string Json = JsonConvert.SerializeObject(All, Formatting.Indented);
            Console.WriteLine(Json);
            //以下為反序列化
            //反序列化:把json字符串轉換回物件
            //JsonConvert.DeserializeObject<T>()這個為反序列化方法
            //其中<>為把JSON字符串反序列化要變成的物件,()放的參數為JSON字符串
            //<AllType>為把Json轉換為AllType物件
            AllType AllData =JsonConvert.DeserializeObject<AllType>(Json);
            Console.WriteLine(" SearchInformation:");
            Console.WriteLine($"擔保日期:{AllData.SearchInformation.CollateralDate}");
            Console.WriteLine($"投資人帳號:{AllData.SearchInformation.Account}");
            Console.WriteLine($"成交狀態:{AllData.SearchInformation.TransactionStatus}");
            Console.WriteLine($"還券狀態:{AllData.SearchInformation.SecuritiesReturnStatus}");       
        }
    }
}
