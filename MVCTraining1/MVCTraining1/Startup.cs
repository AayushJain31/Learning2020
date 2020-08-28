using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using PatientLibrary;
using Microsoft.AspNetCore.Routing;
using HospitalRepository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace MVCTraining1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<HospitalDbContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("HospitalRepository"));
                }
            );
            services.AddAutoMapper(typeof(Startup));
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true; 
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<IPatient, Patient>();
            services.AddScoped<IPatient>((ptx) =>
            {
                IHttpContextAccessor conn = ptx.GetService<IHttpContextAccessor>(); //to get current data of form
                //string ctr = conn.HttpContext.GetRouteValue("PatientController").ToString();
                string _name = conn.HttpContext.Request.Form["txtname"].ToString();
                //string address = conn.HttpContext.Request.Form["address"];
                if(_name == "")
                {
                    return new Patient();
                }
                else
                {
                    return new PatientCheckAddress();
                }
                
            });
            
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseMiddleware<SecurityCheck>();
            //app.UseMiddleware<LogInCheck>();
            ///app.UseMiddleware<CookieMiddleware>();
            //var SessionId = Session.SessionId;
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "PatientAdmit",
                    pattern: "{controller=Patient}/{action=Admit}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
