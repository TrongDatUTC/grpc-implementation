
using GrpcGreeter.DTOs;

namespace GrpcGreeter.Services;

public class DbService : IDbService
{
    public List<Cash> GetList()
    {
        var data = new List<Cash>();
        for (int i = 0; i < 200000; i++)
        {
            data.Add(new Cash
            {
                ClientCode             = "ABCXYZ",
                PurchasingPowerTotal   = 1000,
                CashAmount             = 2000,
                AdvanceAmount          = 3000,
                RemainingBuyingPower   = 4000,
                PendingBuyCash         = 5000,
                MatchedBuyCash         = 6000,
                TransferringAmount     = 7000,
                RemainingCashAmount    = 8000,
                RemainingDebt          = 9000,
                IntradayDebt           = 10000,
                DebtInterest           = 11000,
                ReceivableCashT0       = 12000,
                ReceivableCashT1       = 13000,
                ReceivableCashT2       = 14000,
                ReceivableMatureCW     = 15000,
                ReceivableCashOther    = 16000,
                ReceivableCashTotal    = 17000,
                ReceivableCashOddlot   = 18000,
                ReceivableCashDevidend = 19000,
                Fees                   = 20000,
                NetAssetValue          = 21000,
                Saving                 = 22000,
                SavingTotal            = 23000,
                DateTime               = DateTime.Now
            });
        }
        return data;
    }
}
