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
    }
}
