using blog_api.Database;
using blog_api.Middlewares;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
                options => options.EnableRetryOnFailure()
    ));


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy  =>
        {
            policy.SetIsOriginAllowed(origin =>
			{

                string[] startOrigins = Environment.GetEnvironmentVariable("ALLOWED_ORIGINS_START_BY")?.Split(',') ?? [];

                for(var i=0; i< startOrigins.Length; i++)
                {
                    if (origin.StartsWith(startOrigins[i]))
                    {
                        return true;
                    }
                }

                return false;
			})
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
        });
});

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseSwagger(); // swagger doc
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwagger();
    app.UseSwaggerUI(c =>

    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog API - v1");

    });
}

app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.MapControllers();

app.Run();