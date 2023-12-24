namespace WebApiMock.ControllersApiUx.Account
{
    public class GetAccountDataUx
    {
        public string AccountCode { get; set; } = string.Empty;
        public string AccountTypeCode { get; set; } = "SavingAccount";
        public int AccountBranchCode { get; set; } = 700;
        public string ProductName { get; set; } = "C.A. P. Fisica M/N";
        public string Currency { get; set; } = "Bs";
        public decimal AvailableBalance { get; set; }
    }
}
