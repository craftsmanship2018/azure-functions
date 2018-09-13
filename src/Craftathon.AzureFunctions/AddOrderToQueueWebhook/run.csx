#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

public class Order
{
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public string Email { get; set; }
    public decimal Price { get; set; }
}

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log, IAsyncCollector<Order> orderQueue)
{
    log.Info($"[AddOrderToQueueWebhook]");

    var jsonContent = await req.Content.ReadAsStringAsync();
    var order = JsonConvert.DeserializeObject<Order>(jsonContent);

    log.Info($"Order {order.OrderId} received from {order.Email} for product {order.ProductId}");

    await orderQueue.AddAsync(order);

    return req.CreateResponse(HttpStatusCode.OK, new
    {
        greeting = "Thanks for your order!"
    });
}
