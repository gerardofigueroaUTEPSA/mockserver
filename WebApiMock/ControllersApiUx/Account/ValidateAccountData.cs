namespace WebApiMock.ControllersApiUx.Account
{
    public class ValidateAccountData
    {
    }

    public class ValidateDataAccount 
    { 
        public string PhoneNumber { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
    }

    public class ValidateClientRegisterResponse
    {
        public int OpenedAccounts { get; set; }
    }

    public class ErrorResponse 
    {
        public string Type { get; set; } = "https://www.rfc-editor.org/rfc/rfc7231#section-6.5.1";
        public string Title { get; set; } = "One or more validation errors occurred";
        public int Status { get; set; } = 400;
        public string Instance { get; set; } = "/v1/pagos/bff/client/account/validate";
        public string TraceId { get; set; } = "0HN0GFI2FQHTA:00000001";
        public List<Error> Errors { get; set; } = new List<Error> { };

    }

    public class Error 
    { 
        public string Name { get; set; }
        public string Reason { get; set; }
        public string Code { get; set; }
    }
}
