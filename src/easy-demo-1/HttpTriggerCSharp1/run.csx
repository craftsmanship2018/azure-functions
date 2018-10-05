#r "Newtonsoft.Json"

using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, ILogger log)
{
    log.LogInformation("HTTP Trigger");

    var postData = await req.Content.ReadAsFormDataAsync();
    var name = postData["name"];
 
    log.LogInformation(name);

    if (string.IsNullOrEmpty(name))
        return new HttpResponseMessage(HttpStatusCode.BadRequest) {
            Content = new StringContent("Please submit a name using the form", Encoding.UTF8, "application/json")
        };

    return new HttpResponseMessage(HttpStatusCode.OK) {
        Content = new StringContent($"Hello, {name}", Encoding.UTF8, "application/json")
    };
}
