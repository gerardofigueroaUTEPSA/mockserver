using System;
using System.Net.Mime;

namespace WebApiMock.Controllers.Account;

public class TransactionCode
{
    public int Code { get; set; }
    public int GroupCode { get; set; }
}

public class TransactionDescription
{
    public string Text { get; set; }
}

public class TransactionType 
{ 
    public int ModuleCode { get; set; }
    public int TransactionNumberCode { get; set; }
    public int OrdinalCode { get; set; }
    public string Description { get; set; }
}

public class TransactionData
{
    public string TransactionReferenceId { get; set; } = "10102023/295/400/200/1522";
    public double TransactionAmount { get; set; }
    public string TransactionAccountId { get; set; } = "fdd49c74-6f8e-4350-8582-b2098d3132ed";
    public string TransactionCurrencyCode { get; set; } = "1";
    public string TransactionDebitCredit { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionChannelCode { get; set; } = "3";
    public string TransactionBranchCode { get; set; } = "295";
    public TransactionDescription TransactionBeneficiary { get; set; }
    public TransactionType TransactionType { get; set; }
    public TransactionCode TransactionCode { get; set; } = new TransactionCode { Code = 1522, GroupCode = 400200 };
    public TransactionDescription TransactionDescription { get; set; } = new TransactionDescription { Text = "Pago QR ACH"};
    public TransactionDescription TransactionClientNote { get; set; } = new TransactionDescription
    {
        Text =
            "Remitente: NOMBRECL PATERNOCL Cuenta: 2021661-000-001 Banco: BSOL - Banco Solidario S.A. Glosa:Prueba ACH"
    };
}

public class MovementData
{
    public List<TransactionData> TransactionHistory { get; set; }
}