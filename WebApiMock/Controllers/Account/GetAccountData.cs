namespace WebApiMock.Controllers.Account;

public class AccountModel
{
    public string AccountCodeDisplay { get; set; }
    public string AccountCode { get; set; }
    public string AccountTypeCode { get; set; }
    public int AccountBranchCode { get; set; }
    public string AccountProductName { get; set; }
    public string AccountHolderName { get; set; }
    public int AccountClientCode { get; set; }
    public string AccountStatus { get; set; }
    public int AccountCurrency { get; set; }
    public double AccountAvailableBalance { get; set; }
    public double AccountTotalBalance { get; set; }
    public double AccountRetaindedBalance { get; set; }
}

public static class GetAccountData
{
    public static AccountModel GetAccountById(string id)
    {
        var account1 = new AccountModel
        {
            AccountCodeDisplay = "1111111-000-001",
            AccountCode = "127366",
            AccountTypeCode = "CA",
            AccountBranchCode = 700,
            AccountProductName = "C.A. P. Fisica M/N",
            AccountHolderName = "Yolanda Tomicha",
            AccountClientCode = 1,
            AccountStatus = "NORMAL",
            AccountCurrency = 1,
            AccountAvailableBalance = 12656.35,
            AccountTotalBalance = 12656.35,
            AccountRetaindedBalance = 0
        };

        var account2 = new AccountModel
        {
            AccountCodeDisplay = "2222222-000-002",
            AccountCode = "127366",
            AccountTypeCode = "CA",
            AccountBranchCode = 700,
            AccountProductName = "C.A. P. Fisica M/N",
            AccountHolderName = "Edwin Quispe",
            AccountClientCode = 1,
            AccountStatus = "NORMAL",
            AccountCurrency = 1,
            AccountAvailableBalance = 250.20,
            AccountTotalBalance = 250.20,
            AccountRetaindedBalance = 0
        };

        var account3 = new AccountModel
        {
            AccountCodeDisplay = "3333333-000-003",
            AccountCode = "127366",
            AccountTypeCode = "CA",
            AccountBranchCode = 700,
            AccountProductName = "C.A. P. Fisica M/N",
            AccountHolderName = "Percy Tellez",
            AccountClientCode = 1,
            AccountStatus = "NORMAL",
            AccountCurrency = 1,
            AccountAvailableBalance = 5213.10,
            AccountTotalBalance = 5213.10,
            AccountRetaindedBalance = 0
        };

        if (id == "1000000C-0000-0000-000C-1111C1111C11") { return account1; }
        if (id == "2000000C-0000-0000-000C-2222C2222C22") { return account2; }
        return account3;
    }
}