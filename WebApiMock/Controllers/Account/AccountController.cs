﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace WebApiMock.Controllers.Account;

[ApiController]
public class AccountController : ControllerBase
{
    public AccountController() { }

    [HttpGet]
    [Produces("application/json")]
    [Route("/customer-services/services/product/v1/accounts/{accountId}")]
    public ActionResult<AccountModel> GetAccount(string accountId)
    {
        return Ok(GetAccountData.GetAccountById(accountId));
    }
    
    [HttpGet]
    [Produces("application/json")]
    [Route("/SavingsAccount/{accountId}/History/Retrieve")]
    public ActionResult<MovementData> GetMovements([FromRoute] string accountId, [FromQuery] int page, [FromQuery] int limit, 
        [FromQuery] int minimiunAmount, [FromQuery] int maximunAmount, DateOnly? startDate, DateOnly? endDate)
    {
        string filePath = "";
        switch (accountId) {
            case "1000000C-0000-0000-000C-1111C1111C11":
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Controllers/Account/MovementsUser1.json");
                break;
            case "2000000C-0000-0000-000C-2222C2222C22":
                return NoContent();
            case "3000000C-0000-0000-000C-3333C3333C33":
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Controllers/Account/MovementsUser3.json");
                break;
            default:
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Controllers/Account/MovementsUser1.json");
                break;
        }

        using (StreamReader r = new StreamReader(filePath, Encoding.UTF8))
        {
            string json = r.ReadToEnd();
            var data = JsonConvert.DeserializeObject<MovementData>(json);
            var result = new MovementData { TransactionHistory = data.TransactionHistory };
            
            if (maximunAmount != 0 && minimiunAmount != 0)
            {
                result.TransactionHistory = result.TransactionHistory
                            .Where(m => m.TransactionAmount >= minimiunAmount && m.TransactionAmount <= maximunAmount)
                            .ToList();
            }

            if (startDate != null && endDate != null)
            {
                result.TransactionHistory = result.TransactionHistory
                            .Where(m => DateOnly.FromDateTime(m.TransactionDate) >= startDate && DateOnly.FromDateTime(m.TransactionDate) <= endDate)
                            .ToList();
            }

            result.TransactionHistory = result.TransactionHistory.Skip(limit * (page - 1)).Take(limit).ToList();

            if (data is null || data.TransactionHistory is null || data.TransactionHistory.Count == 0) return NoContent();
            return Ok(result);
        }
    }
}