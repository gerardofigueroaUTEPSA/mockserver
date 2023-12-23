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

public static class GetMovementsData
{
    public static MovementData GetMovementDataPagination(string accountId, int limit)
    {
        if (accountId == "2000000C-0000-0000-000C-2222C2222C22") return new MovementData { TransactionHistory = new List<TransactionData> {  } };
        var data = new List<TransactionData>
        {
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 12, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 4565.45, 
                TransactionDate = new DateTime(2023, 12, 4, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 102.43, 
                TransactionDate = new DateTime(2023, 12, 4, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 200.43, 
                TransactionDate = new DateTime(2023, 12, 4, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 1045.43, 
                TransactionDate = new DateTime(2023, 12, 2, 15, 10,12),
                TransactionDebitCredit = "D"
            },
            new TransactionData
            {
                TransactionAmount = 800, 
                TransactionDate = new DateTime(2023, 12, 1, 15, 10,12),
                TransactionDebitCredit = "D"
            },
            new TransactionData
            {
                TransactionAmount = 300.43, 
                TransactionDate = new DateTime(2023, 11, 30, 15, 10,12),
                TransactionDebitCredit = "D"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            },
            new TransactionData
            {
                TransactionAmount = 100.43, 
                TransactionDate = new DateTime(2023, 10, 5, 15, 10,12),
                TransactionDebitCredit = "C"
            }
        };
        
        return new MovementData
        {
            TransactionHistory = data.Take(limit).ToList()
        };
    }
}