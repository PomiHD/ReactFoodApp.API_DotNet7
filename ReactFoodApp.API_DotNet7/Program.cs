using Microsoft.EntityFrameworkCore;
using ReactFoodApp.API_DotNet7.Data;
using ReactFoodApp.API_DotNet7.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add automapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

//add db context
builder.Services.AddDbContext<FoodAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodAppConnectionString"))
);

//add CORS policy to allow any origin, method, and header
builder.Services.AddCors( options =>
{
    options.AddPolicy( "CustomCorsPolicy" , corsPolicyBuilder =>
    {
        corsPolicyBuilder.AllowAnyOrigin( )
            .AllowAnyMethod( )
            .AllowAnyHeader( );
    } );
} );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("CustomCorsPolicy");
app.MapControllers();

app.Run();
