using RentACar.Application.Features.CQRS.Handlers.AboutHandlers;
using RentACar.Application.Features.CQRS.Handlers.BannerHandlers;
using RentACar.Application.Features.CQRS.Handlers.BrandHandlers;
using RentACar.Application.Features.CQRS.Handlers.CarHandlers;
using RentACar.Application.Features.CQRS.Handlers.CategoryHandlers;
using RentACar.Application.Features.CQRS.Handlers.ContactHandlers;
using RentACar.Application.Interfaces;
using RentACar.Application.Interfaces.BlogInterfaces;
using RentACar.Application.Interfaces.CarInterfaces;
using RentACar.Application.Services;
using RentACar.Persistence.Context;
using RentACar.Persistence.Repositories;
using RentACar.Persistence.Repositories.BlogRepository;
using RentACar.Persistence.Repositories.CarRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//lifeTime
builder.Services.AddScoped<RentACarContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository),typeof(CarRepositories));
builder.Services.AddScoped(typeof(IBlogRepository),typeof(BlogRepository));
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
//brand
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
//car
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetCarLastFiveWithBrandQueryHandler>();
//category
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandle>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();
//contact
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

//mediaR
builder.Services.AddApplicationServices(builder.Configuration);



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
