using System;
using System.Security.Cryptography;
using System.Text;

public class Order
{
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public string Email { get; set; }
    public decimal Price { get; set; }
}

public static void Run(Order order, TraceWriter log, TextWriter blob)
{
    log.Info($"[AddOrderToBlobStorageQueueTrigger]");
    log.Info($"Received order {order.OrderId}, email {order.Email}, product {order.ProductId}");

    blob.WriteLine($"OrderId: {order.OrderId}");
    blob.WriteLine($"Email: {order.Email}");
    blob.WriteLine($"ProductId: {order.ProductId}");
    blob.WriteLine($"PurchaseDate: {DateTime.UtcNow}");

    var md5 = MD5.Create();
    var bytes = Encoding.UTF8.GetBytes(order.Email + "secret");
    var hash = md5.ComputeHash(bytes);
    var code = BitConverter.ToString(hash).Replace("-", "");

    blob.WriteLine($"SecretCode: {code}");
}
