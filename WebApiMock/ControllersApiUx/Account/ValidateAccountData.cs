namespace WebApiMock.ControllersApiUx.Account
{
    public class ValidateAccountData
    {
    }

    public class ValidateDataAccount
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Complement { get; set; } = string.Empty;
    }

    public class ValidateClientRegisterResponse
    {
        public int OpenedAccounts { get; set; }
        public SegipClientResponse SegipClientResponse { get; set; }
    }

    public class SegipClientResponse
    {
        public string CI { get; set; } = string.Empty;
        public string Names { get; set; } = string.Empty;
        public string FirstSurname { get; set; } = string.Empty;
        public string SecondSurname { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string PlaceBirth { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string NameSpouse { get; set; } = string.Empty;
        public string Extension { get; set; }
        public string Department { get; set; }
        public string HomeAddress { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public string RegisterType { get; set; }
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

    public class DepartmentType
    {
        public static Extension GetExtensionEnumForSegipDepartment(string department) =>
            department.Trim() switch
            {
                "SANTA CRUZ" => Extension.SC,
                "BENI" => Extension.BE,
                "PANDO" => Extension.PA,
                "TARIJA" => Extension.TJ,
                "LA PAZ" => Extension.LP,
                "POTOSI" => Extension.PO,
                "COCHABAMBA" => Extension.CB,
                "ORURO" => Extension.OR,
                "CHUQUISACA" => Extension.CH,
                "" => Extension.None,

                _ => throw new ArgumentOutOfRangeException(nameof(department))
            };

        public static Department GetDepartmentEnumForSegipDepartment(string department) =>
            department.Trim() switch
            {
                "SANTA CRUZ" => Department.SantaCruz,
                "BENI" => Department.Beni,
                "PANDO" => Department.Pando,
                "TARIJA" => Department.Tarija,
                "LA PAZ" => Department.LaPaz,
                "POTOSI" => Department.Potosi,
                "COCHABAMBA" => Department.Cochabamba,
                "ORURO" => Department.Oruro,
                "CHUQUISACA" => Department.Chuquisaca,
                "" => Department.None,

                _ => throw new ArgumentOutOfRangeException(nameof(department))
            };
    }

    public enum Extension
    {
        None,
        SC,
        BE,
        PA,
        TJ,
        LP,
        PO,
        CB,
        OR,
        CH
    }

    public enum Department
    {
        None,
        SantaCruz,
        LaPaz,
        Cochabamba,
        Chuquisaca,
        Tarija,
        Beni,
        Oruro,
        Potosi,
        Pando
    }

    public enum GenderType
    {
        Male,
        Female
    }

    public enum IdentificationType
    {
        National,
        Foreign,
        IssuedAbroad
    }

    public enum MaritalStatusType
    {
        Single,
        Married,
        Widower,
        Divorced,
        None
    }
}
