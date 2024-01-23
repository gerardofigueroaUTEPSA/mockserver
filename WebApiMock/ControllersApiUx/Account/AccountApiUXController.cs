﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace WebApiMock.ControllersApiUx.Account
{
    public class AccountApiUXController : ControllerBase
    {
        public AccountApiUXController() { }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/account/{accountId}")]
        public ActionResult<GetAccountDataUx> GetAccount(string accountId)
        {
            string filePath;
            switch (accountId)
            {
                case "1000000C-0000-0000-000C-1111C1111C11":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount1.json");
                    break;
                case "2000000C-0000-0000-000C-2222C2222C22":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount2.json");
                    break;
                case "3000000C-0000-0000-000C-3333C3333C33":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount3.json");
                    break;
                case "4000000C-0000-0000-000C-4444C4444C44":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount4.json");
                    break;
                case "5000000C-0000-0000-000C-5555C5555C55":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount5.json");
                    break;
                case "6000000C-0000-0000-000C-6666C6666C66":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount6.json");
                    break;
                default:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccount1.json");
                    break;
            }

            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<GetAccountDataUx>(json);
                return Ok(data);
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/history/{accountGuid}")]
        public ActionResult<List<GetMovementsDataUx>> GetMovements([FromRoute] string accountGuid, [FromQuery] int page, [FromQuery] int limit,
        [FromQuery] int minimiunAmount, [FromQuery] int maximunAmount, DateOnly? startDate, DateOnly? endDate)
        {
            string filePath = "";
            switch (accountGuid)
            {
                case "1000000C-0000-0000-000C-1111C1111C11":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx1.json");
                    break;
                case "2000000C-0000-0000-000C-2222C2222C22":
                    return NoContent();
                case "3000000C-0000-0000-000C-3333C3333C33":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx3.json");
                    break;
                case "4000000C-0000-0000-000C-4444C4444C44":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx4.json");
                    break;
                case "5000000C-0000-0000-000C-5555C5555C55":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx5.json");
                    break;
                case "6000000C-0000-0000-000C-6666C6666C66":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx6.json");
                    break;
                default:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx1.json");
                    break;
            }

            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<GetMovementsDataUx>>(json);

                if (maximunAmount != 0 && minimiunAmount != 0)
                {
                    data = data.Where(m => m.Amount >= minimiunAmount && m.Amount <= maximunAmount).ToList();
                }

                if (startDate != null && endDate != null)
                {
                    data = data.Where(m => DateOnly.FromDateTime(m.Date) >= startDate && DateOnly.FromDateTime(m.Date) <= endDate).ToList();
                }

                data = data.Skip(limit * (page - 1)).Take(limit).ToList();

                if (data is null || data.Count == 0) return NoContent();
                return Ok(data);
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/account/{accountId}/daily-balance")]
        public ActionResult<GetAccountDailyBalance> GetAccountDailyBalance(string accountId)
        {
            string filePath;
            switch (accountId)
            {
                case "1000000C-0000-0000-000C-1111C1111C11":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance1.json");
                    break;
                case "2000000C-0000-0000-000C-2222C2222C22":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance2.json");
                    break;
                case "3000000C-0000-0000-000C-3333C3333C33":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance3.json");
                    break;
                case "4000000C-0000-0000-000C-4444C4444C44":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance3.json");
                    break;
                case "5000000C-0000-0000-000C-5555C5555C55":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance3.json");
                    break;
                case "6000000C-0000-0000-000C-6666C6666C66":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance3.json");
                    break;
                default:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetAccountDailyBalance1.json");
                    break;
            }

            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<GetAccountDailyBalance>(json);
                return Ok(data);
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/channel-history/{accountGuid}")]
        public ActionResult<GetChannelMovements> GetMovementsChannel([FromRoute] string accountGuid, [FromQuery] int page, [FromQuery] int limit)
        {
            string filePath = "";
            switch (accountGuid)
            {
                case "1000000C-0000-0000-000C-1111C1111C11":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");
                    break;
                case "2000000C-0000-0000-000C-2222C2222C22":
                    return NoContent();
                case "3000000C-0000-0000-000C-3333C3333C33":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");
                    break;
                case "4000000C-0000-0000-000C-4444C4444C44":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");
                    break;
                case "5000000C-0000-0000-000C-5555C5555C55":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");
                    break;
                case "6000000C-0000-0000-000C-6666C6666C66":
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");
                    break;
                default:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");
                    break;
            }

            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<GetChannelMovementsDataUx>>(json);
                var count = data.Count;
                data = data.Skip(limit * (page - 1)).Take(limit).ToList();

                if (data is null || data.Count == 0) return NoContent();

                return Ok(new GetChannelMovements
                {
                    Total = count,
                    Histories = data
                });
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/channel-history/transactions/{id}/detail")]
        public ActionResult<Comprobante> GetDetail([FromRoute] string id)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetHomeMov1.json");

            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<Comprobante>>(json);

                var comprobante = data!.FirstOrDefault(x => x.Id == id);

                return Ok(comprobante);
            }
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/client/account/validate")]
        public ActionResult<ValidateClientRegisterResponse> IsValidAccount([FromBody] ValidateDataAccount request )
        {
            switch (request.PhoneNumber)
            {
                case "74655610":
                    return BadRequest(new ErrorResponse
                    {
                        Errors = new List<Error> {
                        new Error {
                            Name = "generalErrors",
                            Reason = "Necesitamos algunos datos adicionales, acude a cualquier agencia de BancoSol.",
                            Code = "client_restrictive_list"
                        } }
                    });
                case "74655611":
                    return BadRequest(new ErrorResponse { Errors = new List<Error> { 
                        new Error { 
                            Name = "generalErrors", 
                            Reason = "Revisa si el celular registrado es correcto o registra otro número que te pertenezca", 
                            Code = "existing_phone_number" 
                        } } });
                case "74655612":
                    return BadRequest(new ErrorResponse { Errors = new List<Error> { 
                        new Error { 
                            Name = "generalErrors",
                            Reason = "Llegaste al limite de cuentas 5 ingresa con tu número de celular y tu PIN", 
                            Code = "max_client_accounts"
                        } } });
                case "74655613":
                    return Ok(new ValidateClientRegisterResponse 
                    { 
                        OpenedAccounts = 1,
                        IsNewClient = false,
                        SegipClientResponse = new SegipClientResponse
                        {
                            CI = request.DocumentNumber,
                            Names = "Luis Gerardo",
                            FirstSurname = "Figueroa",
                            SecondSurname = "Zurita",
                            Nationality = "Boliviana",
                            PlaceBirth = "Santa Cruz de la Sierra",
                            DateOfBirth = new DateTime(1997, 2, 19),
                            MaritalStatus = "C",
                            Gender = GenderType.Male.ToString(),
                            NameSpouse = string.Empty,
                            Extension = Extension.SC.ToString(),
                            Department = Department.SantaCruz.ToString(),
                            HomeAddress = "B/Curupau 4to anillo #4025",
                            Occupation = "Estudiante",
                            RegisterType = IdentificationType.National.ToString()
                        }
                    });
                case "74655614":
                    return Ok(new ValidateClientRegisterResponse
                    {
                        OpenedAccounts = 0,
                        IsNewClient = false,
                        SegipClientResponse = new SegipClientResponse
                        {
                            CI = request.DocumentNumber,
                            Names = "Luis Gerardo",
                            FirstSurname = "Figueroa",
                            SecondSurname = "Zurita",
                            Nationality = "Boliviana",
                            PlaceBirth = "Santa Cruz de la Sierra",
                            DateOfBirth = new DateTime(1997, 2, 19),
                            MaritalStatus = "C",
                            Gender = GenderType.Male.ToString(),
                            NameSpouse = string.Empty,
                            Extension = Extension.SC.ToString(),
                            Department = Department.SantaCruz.ToString(),
                            HomeAddress = "B/Curupau 4to anillo #4025",
                            Occupation = "Estudiante",
                            RegisterType = IdentificationType.National.ToString()
                        }
                    });
                case "74655615":
                    return Ok(new ValidateClientRegisterResponse
                    {
                        OpenedAccounts = 0,
                        IsNewClient = false,
                        SegipClientResponse = new SegipClientResponse
                        {
                            CI = request.DocumentNumber,
                            Names = "Luis Gerardo",
                            FirstSurname = "Figueroa",
                            SecondSurname = "Zurita",
                            Nationality = "Boliviana",
                            PlaceBirth = "Santa Cruz de la Sierra",
                            DateOfBirth = new DateTime(1997, 2, 19),
                            MaritalStatus = "C",
                            Gender = GenderType.Male.ToString(),
                            NameSpouse = string.Empty,
                            Extension = Extension.SC.ToString(),
                            Department = Department.SantaCruz.ToString(),
                            HomeAddress = "B/Curupau 4to anillo #4025",
                            Occupation = "Estudiante",
                            RegisterType = IdentificationType.National.ToString()
                        }
                    });
                case "74655616":
                    return Ok(new ValidateClientRegisterResponse
                    {
                        OpenedAccounts = 0,
                        IsNewClient = true,
                        SegipClientResponse = new SegipClientResponse
                        {
                            CI = request.DocumentNumber,
                            Names = "Luis Gerardo",
                            FirstSurname = "Figueroa",
                            SecondSurname = "Zurita",
                            Nationality = "Boliviana",
                            PlaceBirth = "Santa Cruz de la Sierra",
                            DateOfBirth = new DateTime(1997, 2, 19),
                            MaritalStatus = "S",
                            Gender = GenderType.Male.ToString(),
                            NameSpouse = string.Empty,
                            Extension = Extension.SC.ToString(),
                            Department = Department.SantaCruz.ToString(),
                            HomeAddress = "B/Curupau 4to anillo #4025",
                            Occupation = "Estudiante",
                            RegisterType = IdentificationType.National.ToString()
                        }
                    });
                default:
                    return Ok(new ValidateClientRegisterResponse
                    {
                        OpenedAccounts = 0,
                        IsNewClient = true,
                        SegipClientResponse = new SegipClientResponse 
                        { 
                            CI = request.DocumentNumber,
                            Names = "Luis Gerardo",
                            FirstSurname = "Figueroa",
                            SecondSurname = "Zurita",
                            Nationality = "Boliviana",
                            PlaceBirth = "Santa Cruz de la Sierra",
                            DateOfBirth = new DateTime(1997, 2, 19),
                            MaritalStatus = "C",
                            Gender = GenderType.Male.ToString(),
                            NameSpouse = "Tylor Swift",
                            Extension = Extension.SC.ToString(),
                            Department = Department.SantaCruz.ToString(),
                            HomeAddress = "B/Curupau 4to anillo #4025",
                            Occupation = "Estudiante",
                            RegisterType = IdentificationType.National.ToString()
                        }
                    });
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/history/{voucherId}/voucher")]
        public ActionResult<ComprobanteCore> GetVoucher([FromRoute] string voucherId)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx1.json");
            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<ComprobanteCore>>(json);
                var result = data!.FirstOrDefault(x => x.ReferenceId == voucherId);
                return Ok(result);
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/history/voucher")]
        public ActionResult<ComprobanteCore> GetVoucherQuery([FromQuery] string voucherId)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/GetMovementsUx1.json");
            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<ComprobanteCore>>(json);
                var result = data!.FirstOrDefault(x => x.ReferenceId == voucherId);
                return Ok(result);
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/client/{documentNumber}/segip")]
        public ActionResult<SegipClientResponse> GetSegip([FromRoute] string documentNumber, [FromQuery] string complement)
        {
            return Ok(
                   new SegipClientResponse
                   {
                       CI = documentNumber,
                       Names = "Luis Gerardo",
                       FirstSurname = "Figueroa",
                       SecondSurname = "Zurita",
                       Nationality = "Boliviana",
                       PlaceBirth = "Santa Cruz de la Sierra",
                       DateOfBirth = new DateTime(1997, 2, 19),
                       MaritalStatus = MaritalStatusType.Single.ToString(),
                       Gender = GenderType.Male.ToString(),
                       NameSpouse = string.Empty,
                       Extension = Extension.SC.ToString(),
                       Department = Department.SantaCruz.ToString(),
                       HomeAddress = "B/Curupau 4to anillo #4025",
                       Occupation = "Estudiante",
                       RegisterType = IdentificationType.National.ToString()
                   }
            );
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/customer/onboarding/catalogs")]
        public ActionResult<Catalogs> GetCatalog()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/catalogos.json");

            using(StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<Catalogs>(json);
                return Ok(result);
            }
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/{informativeDocumentName}/informative-documents")]
        public ActionResult<ResponseDocument> GetDocument([FromRoute] InformativeDocumentName informativeDocumentName)
        {
            var filePath = "";
            switch (informativeDocumentName) 
            {
                case InformativeDocumentName.CONTRACT:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/documents/contract.json");
                    break;
                case InformativeDocumentName.REGULATIONS:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/documents/regulations.json");
                    break;
                case InformativeDocumentName.TERMS:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/documents/terms.json");
                    break;
                default:
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ControllersApiUx/Account/documents/terms.json");
                    break;
            }

            using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<ResponseDocument>(json);
                return Ok(result);
            }
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/otp/send")]
        public ActionResult<SendOtpResponse> SendOtp([FromBody] SendOtpRequest request) 
        {
            switch (request.PhoneNumber) 
            {
                case "70000001": 
                    return Ok(new SendOtpResponse { Sid = "VEfeb8916328c15d871240cf34742566b6" });
                case "70000002":
                    return BadRequest(
                        new ErrorResponse 
                        { 
                            Errors = 
                                { 
                                    new Error 
                                    { 
                                        Code = "invalid_phone_number", 
                                        Name = "generalErrors", 
                                        Reason = "El número de telefono es inválido." 
                                    } 
                            }
                        }
                    );
                default: return Ok(new SendOtpResponse { Sid = "VEfeb8916328c15d871240cf34742566b6" });
            }
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/otp/verify")]
        public ActionResult<VerifyOtpResponse> VerifyOtp([FromBody] VerifyOtpRequest request)
        {
            switch (request.Code)
            {
                case "1111":
                    return Ok(new VerifyOtpResponse());
                case "2222":
                    return BadRequest(
                        new ErrorResponse
                        {
                            Errors =
                                {
                                    new Error
                                    {
                                        Code = "max_attempts_reached",
                                        Name = "generalErrors",
                                        Reason = "Se alcanzó el intento máximo de verificaciones con este código."
                                    }
                            }
                        }
                    );
                case "3333":
                    return BadRequest(
                        new ErrorResponse
                        {
                            Errors =
                                {
                                    new Error
                                    {
                                        Code = "invalid_code",
                                        Name = "generalErrors",
                                        Reason = "El código es inválido"
                                    }
                            }
                        }
                    );
                case "4444":
                    return BadRequest(
                        new ErrorResponse
                        {
                            Errors =
                                {
                                    new Error
                                    {
                                        Code = "expired_code",
                                        Name = "generalErrors",
                                        Reason = "El código expiró."
                                    }
                            }
                        }
                    );
                default: return Ok(new VerifyOtpResponse());
            }
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/customer")]
        public ActionResult<ClientRegisterResponse> RegisterClient([FromBody] ClientRegisterRequest request) 
        {
            return Ok(new ClientRegisterResponse{ PartyId = "12345" });
        }
    }
}
