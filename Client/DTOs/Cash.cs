using System.Text.Json.Serialization;

namespace GrpcGreeterClient.DTOs;

public class Cash
{
    [JsonPropertyName("clientCode")]
    public virtual string ClientCode { get; set; }
    [JsonPropertyName("purchasingPowerTotal")]

    public virtual long PurchasingPowerTotal { get; set; }
    [JsonPropertyName("cashAmount")]
    public virtual long CashAmount { get; set; }
    [JsonPropertyName("advanceAmount")]
    public virtual long AdvanceAmount { get; set; }
    [JsonPropertyName("remainingBuyingPower")]
    public virtual long RemainingBuyingPower { get; set; }
    [JsonPropertyName("pendingBuyCash")]
    public virtual long PendingBuyCash { get; set; }
    [JsonPropertyName("matchedBuyCash")]
    public virtual long MatchedBuyCash { get; set; }
    [JsonPropertyName("transferringAmount")]
    public virtual long TransferringAmount { get; set; }
    [JsonPropertyName("remainingCashAmount")]
    public virtual long RemainingCashAmount { get; set; }
    [JsonPropertyName("remainingDebt")]
    public virtual long RemainingDebt { get; set; }
    [JsonPropertyName("intradayDebt")]
    public virtual long IntradayDebt { get; set; }
    [JsonPropertyName("debtInterest")]
    public virtual long DebtInterest { get; set; }
    [JsonPropertyName("receivableCashT0")]
    public virtual long ReceivableCashT0 { get; set; }
    [JsonPropertyName("receivableCashT1")]
    public virtual long ReceivableCashT1 { get; set; }
    [JsonPropertyName("receivableCashT2")]
    public virtual long ReceivableCashT2 { get; set; }
    [JsonPropertyName("receivableMatureCW")]
    public virtual long ReceivableMatureCW { get; set; }
    [JsonPropertyName("receivableCashOther")]
    public virtual long ReceivableCashOther { get; set; }
    [JsonPropertyName("receivableCashTotal")]
    public virtual long ReceivableCashTotal { get; set; }
    [JsonPropertyName("receivableCashOddlot")]
    public virtual long ReceivableCashOddlot { get; set; }
    [JsonPropertyName("receivableCashDevidend")]
    public virtual long ReceivableCashDevidend { get; set; }
    [JsonPropertyName("fees")]
    public virtual long Fees { get; set; }
    [JsonPropertyName("netAssetValue")]
    public virtual long NetAssetValue { get; set; }
    [JsonPropertyName("saving")]
    public virtual long Saving { get; set; }
    [JsonPropertyName("savingTotal")]
    public virtual long SavingTotal { get; set; }
    [JsonPropertyName("dateTime")]
    public virtual DateTime DateTime { get; set; } = DateTime.Now;
}
