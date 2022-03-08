//dependencies 
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using Dapr;
using Dapr.Client;

//code
namespace CheckoutService.controller
{
    [ApiController]
    public class CheckoutServiceController : Controller
    {
         //Subscribe to a topic 
        [Topic("order_pub_sub", "orders")]
        [HttpPost("/checkout")]
        public string GetCheckout([FromBody] int orderId)
        {
            Console.WriteLine("Subscriber received : " + orderId);
            return "Subscriber received : " + orderId;
        }
    }
}
