using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebApiMock.ControllersApiUx.Account
{
    public class GetMovementsDataUx
    {
        public string ReferenceId { get; set; }
        public decimal Amount { get; set; }
        public string DebitCredit { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string TypeTransaction { get; set; }
        public string Voucher { get; set; } = "102402302";
        public string Currency { get; set; } = "Bs";
        public string Status { get; set; } = "Confirmed";
    }

    public class GetChannelMovementsDataUx
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public string DebitCredit { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string TransactionTypeDescription { get; set; }
        public string Voucher { get; set; } 
        public string Currency { get; set; } 
        public string Status { get; set; }
    }

    public class GetChannelMovements 
    {
        public int Total { get; set; }
        public List<GetChannelMovementsDataUx> Histories { get; set; } = new List<GetChannelMovementsDataUx> { };
    }

    public class Comprobante 
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string OriginName { get; set; }
        public string OriginAccount { get; set; }
        public string OriginBank { get; set; }
        public string DebitCredit { get; set; }
        public DateTime Date { get; set; }
        public string Voucher { get; set; }
        public string TransactionType { get; set; }
        public string DestinationName { get; set; } 
        public string DestinationAccount { get; set; } 
        public string DestinationBank { get; set; }
    }

    public class ComprobanteCore
    {
        public string ReferenceId { get; set; }
        public decimal Amount { get; set; }
        public string DebitCredit { get; set; }
        public DateTime Date { get; set; }
        public string Voucher { get; set; }
        public string Currency { get; set; } = "Bs";

        public string TransactionType { get; set; }
        public string TransactionTypeDescription { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountBank { get; set; }
        public string Description { get; set; }
    }
}
