namespace GrpcGreeter.Services;

using Grpc.Core;
using GrpcGreeter.DTOs;
using GrpcCash;

public class CashServiceImpl : CashService.CashServiceBase
{
    private readonly IDbService _dbService;
    public CashServiceImpl(IDbService dbService)
    {
        _dbService = dbService; 
    }
    public override async Task GetCashData(CashRequest request, IServerStreamWriter<CashData> responseStream, ServerCallContext context)
    {
        var cashDataList = _dbService.GetList();
        foreach (var data in cashDataList)
        {
            await responseStream.WriteAsync(new CashData
            {
                ClientCode             = data.ClientCode,
                PurchasingPowerTotal   = data.PurchasingPowerTotal,
                CashAmount             = data.CashAmount,
                AdvanceAmount          = data.AdvanceAmount,
                RemainingBuyingPower   = data.RemainingBuyingPower,
                PendingBuyCash         = data.PendingBuyCash,
                MatchedBuyCash         = data.MatchedBuyCash,
                TransferringAmount     = data.TransferringAmount,
                RemainingCashAmount    = data.RemainingCashAmount,
                RemainingDebt          = data.RemainingDebt,
                IntradayDebt           = data.IntradayDebt,
                DebtInterest           = data.DebtInterest,
                ReceivableCashT0       = data.ReceivableCashT0,
                ReceivableCashT1       = data.ReceivableCashT1,
                ReceivableCashT2       = data.ReceivableCashT2,
                ReceivableMatureCw     = data.ReceivableMatureCW,
                ReceivableCashOther    = data.ReceivableCashOther,
                ReceivableCashTotal    = data.ReceivableCashTotal,
                ReceivableCashOddlot   = data.ReceivableCashOddlot,
                ReceivableCashDividend = data.ReceivableCashDevidend,
                Fees                   = data.Fees,
                NetAssetValue          = data.NetAssetValue,
                Saving                 = data.Saving,
                SavingTotal            = data.SavingTotal,
                Datetime               = data.DateTime.ToString("o")
            });
        }
    }
}