using System.IO;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    StreamReader reader = new StreamReader(context.Request.Body);
    string body = await reader.ReadToEndAsync();
    //if (body == "Hello") { }
    Dictionary<string, StringValues> queryDict =
    Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);
    if (queryDict.ContainsKey("firstName"))
    {
        string firstName = queryDict["firstName"][0];
        await context.Response.WriteAsync(firstName);
    }

}



);

app.Run();
