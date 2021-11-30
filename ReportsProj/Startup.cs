using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraReports.Web.Extensions;
using ReportsProj.DBC;
using Microsoft.EntityFrameworkCore;

using DevExpress.DashboardAspNetCore;//Dashboard
using DevExpress.DashboardWeb;//Dashboard
using Microsoft.Extensions.FileProviders;//Dashboard
using DevExpress.XtraReports.Web.ClientControls;

namespace ReportsProj
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IFileProvider FileProvider { get; }   //Dashboard

        public Startup(IConfiguration configuration,
                       IWebHostEnvironment hostingEnvironment)  //Dashboard

        {
            Configuration = configuration;
            FileProvider = hostingEnvironment.ContentRootFileProvider;

        }



        // This method gets called by the runtime. Use this method to add services to the container.aaa Management
        //...
        public void ConfigureServices(IServiceCollection services)
        {
            // Dashboard
            services.AddDevExpressControls().AddControllersWithViews()
                .AddDefaultDashboardController(configurator => {
                    configurator.SetDashboardStorage(new DashboardFileStorage(FileProvider.GetFileInfo("Data/Dashboards").PhysicalPath));
                    configurator.SetConnectionStringsProvider(new DashboardConnectionStringsProvider(Configuration));
                });

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy",
            //        builder => builder.AllowAnyOrigin()
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        .AllowCredentials());
            //});
            
            services.AddDbContext<PM_DBC>(options =>options.UseSqlServer(Configuration.GetSection("ConnectionStrings").GetSection("PM").Value));
            services.AddDbContext<CSR_DBC>(options =>options.UseSqlServer(Configuration.GetSection("ConnectionStrings").GetSection("CSR").Value));
            services.AddDbContext<Pharmacy_DBC>(options =>options.UseSqlServer(Configuration.GetSection("ConnectionStrings").GetSection("Pharm_Connection").Value));
            services.AddDbContext<Clinics_DBC>(options =>options.UseSqlServer(Configuration.GetSection("ConnectionStrings").GetSection("CLINIC_Connection").Value));
            //services.AddDbContext<Management_DBC>(options => options.UseSqlServer(Configuration.GetSection("ConnectionStrings").GetSection("Management").Value));
            services.AddDbContext<Management_DBC>(options => options.UseSqlServer(this.Configuration.GetConnectionString("Management"),sqlServerOptions => sqlServerOptions.CommandTimeout(600)));

            services.AddControllersWithViews();
            services.AddDevExpressControls();
           // services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>(); ////-- Excluded His File From Project From Root >> Services
            services.AddMvc().AddNewtonsoftJson().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.ConfigureReportingServices(configurator => {
                configurator.ConfigureReportDesigner(designerConfigurator => {
                    designerConfigurator.RegisterDataSourceWizardConfigFileConnectionStringsProvider();
                });
                configurator.ConfigureWebDocumentViewer(viewerConfigurator => {
                    viewerConfigurator.UseCachedReportSourceBuilder();
                });
            });
        }
        //...
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDevExpressControls();
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseDeveloperExceptionPage();
                // The default HSTS value is 30 days. You may want to change this for production scenarios (see https://aka.ms/aspnetcore-hsts).
                app.UseHsts();

            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                // Bleow Line To Maps the dashboard route .
                EndpointRouteBuilderExtension.MapDashboardRoute(endpoints, "api/dashboards");

                endpoints.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            //-- To Log Error DevExpress.XtraReports
            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(new LoggerService());
        }
        // ...

    }
}
