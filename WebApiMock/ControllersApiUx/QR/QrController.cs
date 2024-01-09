using Microsoft.AspNetCore.Mvc;

namespace WebApiMock.ControllersApiUx.QR
{
    [ApiController]
    public class QrController : ControllerBase
    {
        public QrController() { }

        [HttpPost]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/qr")]
        public ActionResult CreateQR([FromBody] QrCreateRequest request) 
        {
            return Ok(
                new
                {
                    QrEncrypted = "fIZLlAl/9u6AMDu6t0w48QdDXu6DlZLEHCRKXAWlTSU/QDUAfccTph/8TwO+G+fKfsN7PTbav3bxHf9UtauozHBDBspsIhA9weGiZTj8QqlF/03dmgWWUQiR45w4aw00bG/EAeq4LbS02MrHjK1gD/jwBH5Uj8seh7luT++N3hJ6fXUCVQYfd9sTAolduCghJlPrBbRqEk3NTC5QV+UiwzuFQIvqjmNZrTxZVQihwsKZh7nL6+UZVI4q7pU3QDys0NuJnVDWfg2lumLElTR2cukEyPy9Er+zqWhTAWkKBVUw7/UWxiUxoXvJi6YfVBn1kF770nvOyxsNG9mgbtaW/w==|1bdaf2a7000200036349"
                }
            );
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/v1/pagos/bff/qr")]
        public ActionResult DecryptQR([FromQuery] string QrEncrypted)
        {
            return Ok(
            new {
                Id = "23672367326871637",
                DestinationName = "Gerardo Figueroa Zurita",
                DocumentNumber = "9746660",
                BankCode = "Banco de Crédito",
                DestinationAccount = "2454654",
                Currency = "Bs",
                Amount = 1000.23,
                Description = "Este es mi primer QR",
                ExpirationDate = "2023-12-30",
                SingleUse = true
            });
        }
    }
}
