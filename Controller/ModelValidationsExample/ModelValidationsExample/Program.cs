using ModelValidationsExample.CustomModelBinders;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(option => { option.ModelBinderProviders.Insert(0, new PersonBinderProvider()); });
builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
