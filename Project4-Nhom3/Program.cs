
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using ServiceLayer.Service;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));


        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddTransient<IBaiVietService, BaiVietService>();
        builder.Services.AddTransient<IBannerService, BannerService>();
        builder.Services.AddTransient<IBinhLuanService, BinhLuanService>();
        builder.Services.AddTransient<IDanhMucSanPhamService, DanhMucSanPhamService>();
        builder.Services.AddTransient<IFeedbackService, FeedbackService>();
        builder.Services.AddTransient<IGioHangService, GioHangService>();
        builder.Services.AddTransient<IKeySPService, KeySPService>();
        builder.Services.AddTransient<IRoleService, RoleService>();
        builder.Services.AddTransient<ISanPhamService, SanPhamService>();
        builder.Services.AddTransient<IUserService, UserService>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        });
        app.Run();
    }
}