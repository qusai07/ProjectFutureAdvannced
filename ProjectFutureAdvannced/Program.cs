var builder = WebApplication.CreateBuilder(args);



#region ConfigureService
/**********add mvc*********/
builder.Services.AddMvc(options =>
{
    options.EnableEndpointRouting = false;
}
).AddXmlSerializerFormatters();

#endregion
/***************************************/
var app = builder.Build();
/***************************************/

#region ConfigureService
if(app.Environment.IsDevelopment())
    {
    app.UseDeveloperExceptionPage();
    }
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
#endregion



app.Run();
