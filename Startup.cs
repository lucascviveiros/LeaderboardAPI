using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LeaderboardAPI 
{
    public class Startup
    {
        // Este método é usado para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configurações dos serviços da aplicação (por exemplo, MVC, Entity Framework, etc.)
            services.AddControllersWithViews();
        }

        // Este método é usado para configurar o pipeline de solicitação HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Página de erro detalhada em ambiente de desenvolvimento
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Página de erro em ambiente de produção
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // Redireciona requisições HTTP para HTTPS
            app.UseStaticFiles(); // Habilita o uso de arquivos estáticos (por exemplo, CSS, JavaScript)

            app.UseRouting(); // Habilita o roteamento de solicitações HTTP

            app.UseAuthorization(); // Habilita a autorização (se necessário)

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
