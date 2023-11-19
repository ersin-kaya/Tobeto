using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//dependency chain -> bağımlılık zinciri: service manager'a o da dal'a ihtiyaç duyar
//bağlantılar kurarken genelde katmanların soyutu kullanılır
//services.Add.Singleton<>() -> bana arkaplanda bir ref oluştur. asp.net bunu kendisi arkaplanda yapar ve istenilen bağımlılıkları saklar. örn: service verilirse manager'ını new'ler

//Course
builder.Services.AddSingleton<ICourseService, CourseManager>();
builder.Services.AddSingleton<ICourseDal, EfCourseDal>();

//Instructor
builder.Services.AddSingleton<IInstructorService, InstructorManager>();
builder.Services.AddSingleton<IInstructorDal, EfInstructorDal>();

//Category
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

//örneğin: sepetin singleton olmaması lazım çünkü böyle bir durumda aynı instance'ı kullanan tüm kullanıcıların sepeti ortak olacaktır

//services.AddSingleton<IProductService, ProductManager>(); -->> IProductService productManager = new ProductManager;
//yapısını yapmış oluruz

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
