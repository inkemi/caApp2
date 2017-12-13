using System.Data.Common;
using ContactWebApi.Models;
using ContactWebApi.Repositories;
using ContactWebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ContactWebApi
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

            // var connection = connectString;
            // var connection = @"Server = (localdb)\mssqllocaldb; Database = ContactAppDB; Trusted_Connection = True; ";
             var connection =
                @"Server = tcp:3k00d1contact.database.windows.net,1433; Initial Catalog = contactsdb; Persist Security Info = False; User ID = ; Password =; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

            services.AddDbContext<ContactContext>(options => options.UseSqlServer(connection));

            services.AddCors(o => o.AddPolicy("ContactsAppPolicy", builder =>
            {
               builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("ContactsAppPolicy");
            app.UseMvc();
        }
    }
}
