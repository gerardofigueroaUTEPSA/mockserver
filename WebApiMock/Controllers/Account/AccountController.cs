using Microsoft.AspNetCore.Mvc;

namespace WebApiMock.Controllers.Account;

[ApiController]
public class AccountController : ControllerBase
{
    public AccountController() { }

    [HttpGet]
    [Route("/customer-services/services/product/v1/accounts/{accountId}/")]
    public ActionResult<AccountModel> GetAccount(string accountId)
    {
        return Ok(GetAccountData.GetAccountById(accountId));
    }
    
    [HttpGet]
    [Route("/SavingsAccount/{accountId}/History/Retrieve?page={page}&limit={limit}")]
    public ActionResult<MovementData> GetMovements(string accountId, int page, int limit)
    {
        var data = GetMovementsData.GetMovementDataPagination(accountId, limit);
        if (data.TransactionHistory.Count == 0) return NoContent();
        return Ok(data);
    }
}