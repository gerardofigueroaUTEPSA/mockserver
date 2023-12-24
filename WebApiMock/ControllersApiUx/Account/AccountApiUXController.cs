using Microsoft.AspNetCore.Mvc;
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
    }
}
