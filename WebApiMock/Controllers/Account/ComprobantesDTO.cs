using System.Text.Json.Serialization;

namespace WebApiMock.Controllers.Account
{
    public class ComprobanteRaiz
    {
        [JsonIgnore]
        public string Id { get; set; }
        public TransactionVoucher TransactionVoucher { get; set; }
    }

    public class TransactionVoucher
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public int Currency { get; set; }
        public DateTime date { get; set; }
        public string PayerOriginHolder { get; set; }
        public PayerProductInstanceReference PayerProductInstanceReference { get; set; }
        public TransactionTypeData TransactionType { get; set; }
        public TransactionDescription TransactionDescription { get; set; }
        public List<Details> Details { get; set; }
    }

    public class Details 
    { 
        public string Type { get; set; }
        public string Text { get; set; }
    }

    public class PayerProductInstanceReference
    {
        public string ReferenceAccountDisplayName { get; set; }
        public string ReferenceAccountTypeName { get; set; }
    }

    public class TransactionTypeData
    { 
        public int ModuleCode { get; set; }
        public int TransactionNumberCode { get; set; }
        public int OrdinalCode { get; set; }
        public string Description { get; set; }
    }
}
