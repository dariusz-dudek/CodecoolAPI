var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMvc();
builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddRazorPages();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var connectionString = builder.Configuration.GetConnectionString("CodecoolAPIDB");
builder.Services.AddDbContext<CodecoolAPIContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
