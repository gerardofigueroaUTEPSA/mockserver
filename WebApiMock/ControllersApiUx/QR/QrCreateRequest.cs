using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiMock.ControllersApiUx.QR
{
    public class QrCreateRequest 
    {
        public string DestinationAccount { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string ExpirationDate { get; set; }
        public bool SingleUse { get; set; }
    }
}
