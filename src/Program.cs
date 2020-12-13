using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Shop.Services;

namespace Shop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); //This code gets the base address of the evironment as URI

            builder.Services.AddScoped<CompanyFilter>();
            
            // TODO 1: Change the localhost to your API address
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:4001") });
            

            builder.Services.AddOidcAuthentication(options =>
            {
                // Configure your authentication provider options here.
                // For more information, see https://aka.ms/blazor-standalone-auth
                builder.Configuration.Bind("Local", options.ProviderOptions);
            });


            builder.Services.AddOidcAuthentication(options =>
            {
                //TODO 2: enter you client Id and secret in appsettings.json
                builder.Configuration.Bind("Google", options.ProviderOptions);
                options.AuthenticationPaths.ProfilePath = "security/profile";
                options.ProviderOptions.ResponseType = "id_token";
                options.UserOptions.AuthenticationType = "google";
            });
            
            builder.Services.AddApiAuthorization(options => { 
                options.AuthenticationPaths.LogInPath = "security/login";
                options.AuthenticationPaths.LogInCallbackPath = "security/login-callback";
                options.AuthenticationPaths.LogInFailedPath = "security/login-failed";
                options.AuthenticationPaths.LogOutPath = "security/logout";
                options.AuthenticationPaths.LogOutCallbackPath = "security/logout-callback";
                options.AuthenticationPaths.LogOutFailedPath = "security/logout-failed";
                options.AuthenticationPaths.LogOutSucceededPath = "security/logged-out";
                options.AuthenticationPaths.ProfilePath = "security/profile";
                options.AuthenticationPaths.RegisterPath = "security/register";
            });

            await builder.Build().RunAsync();
        }
    }
}
