namespace GrpcGreeter.DTOs;

public class Cash
{
    public virtual string ClientCode { get; set; }
    public virtual long PurchasingPowerTotal { get; set; }
    public virtual long CashAmount { get; set; }
    public virtual long AdvanceAmount { get; set; }
    public virtual long RemainingBuyingPower { get; set; }
    public virtual long PendingBuyCash { get; set; }
    public virtual long MatchedBuyCash { get; set; }
    public virtual long TransferringAmount { get; set; }
    public virtual long RemainingCashAmount { get; set; }
    public virtual long RemainingDebt { get; set; }
    public virtual long IntradayDebt { get; set; }
    public virtual long DebtInterest { get; set; }
    public virtual long ReceivableCashT0 { get; set; }
    public virtual long ReceivableCashT1 { get; set; }
    public virtual long ReceivableCashT2 { get; set; }
    public virtual long ReceivableMatureCW { get; set; }
    public virtual long ReceivableCashOther { get; set; }
    public virtual long ReceivableCashTotal { get; set; }
    public virtual long ReceivableCashOddlot { get; set; }
    public virtual long ReceivableCashDevidend { get; set; }
    public virtual long Fees { get; set; }
    public virtual long NetAssetValue { get; set; }
    public virtual long Saving { get; set; }
    public virtual long SavingTotal { get; set; }
    public virtual DateTime DateTime { get; set; } = DateTime.Now;
}
