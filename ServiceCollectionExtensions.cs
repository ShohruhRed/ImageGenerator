using Azure;
using Microsoft.Extensions.Azure;

namespace ImageGenerator
{
    public static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddAzureOpenAI(
       this IServiceCollection services, IConfiguration config)
        {
            services.AddAzureClients(
                factory =>
                {
                    string proxyUrl = "";
                    string key = "";

                    // the full url is appended by /v1/api
                    Uri proxyUri = new(proxyUrl + "/v1/api");

                    // the full key is appended by "/YOUR-GITHUB-ALIAS"
                    AzureKeyCredential token = new(key + "/ShohruhRed");

                    factory.AddOpenAIClient(
                        new Uri(proxyUri.ToString()), new AzureKeyCredential(key + "/ShohruhRed"));
                });

            return services;
        }
    }
}
