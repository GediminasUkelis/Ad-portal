using API.Middleware;
using AutoMapper;
using BLL.CarService.Queries;
using BLL.Infastructure.AutoMapper;
using BLL.Infastructure.UnitOfWork;
using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Data;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text;

namespace API
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
            services.AddLogging();
           services.AddCors();
            
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer("server=.;database=ad-Portal;trusted_connection=true;"));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(List.Handler).Assembly);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();
            services.AddHttpContextAccessor();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);//We set Time here 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
         .AddJwtBearer(x =>
         {
             var SecretKey = Encoding.ASCII.GetBytes("MyKey-sdasdas2c5981ASD11cqsqWEDcsq6c5QWDQW1ds2d1321qcqc0sq0qsc23qf6q5s4df3Q234WDq2s1d");
             x.RequireHttpsMetadata = false;
             x.SaveToken = true;
             x.TokenValidationParameters = new TokenValidationParameters
             {
                 ValidateIssuerSigningKey = true,
                 IssuerSigningKey = new SymmetricSecurityKey(SecretKey),
                 ValidateIssuer = false,
                 ValidateAudience = false
             };
         });
            services.AddMvc()
                .AddNewtonsoftJson(options =>
             options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMiddleware<ErrorHandling>();
            }
            else
            {
                app.UseMiddleware<ErrorHandling>();
            }
            app.UseHttpsRedirection();   
            app.UseRouting();
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseSession();
            app.Use(async (context, next) =>
            {
                var JWTToken = context.Session.GetString("JwtToken");
                if (!string.IsNullOrEmpty(JWTToken))
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + JWTToken);
                }
                await next();
            });
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
