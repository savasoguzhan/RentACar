using RentACar.Application.Features.Handlers.AboutHandlers;
using RentACar.Application.Features.Handlers.BannerHandlers;
using RentACar.Application.Interfaces;
using RentACar.Persistence.Context;
using RentACar.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//lifeTime
builder.Services.AddScoped<RentACarContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
//about
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
//banner
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdataBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();