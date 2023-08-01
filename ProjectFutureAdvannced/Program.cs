using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.SqlRepository;

var builder = WebApplication.CreateBuilder(args);



#region ConfigureService
/**********add mvc*********/
builder.Services.AddMvc(options =>
{
    options.EnableEndpointRouting = false;
}
).AddXmlSerializerFormatters();
/*******************ConnectionString*********************/
builder.Services.AddDbContextPool<AppDbContext>(options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("StoreConnectionStrings"));
});
/*********Dependency Injection**********/
builder.Services.AddScoped<ICategoryRepository, SqlCategoryRepository>();
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
