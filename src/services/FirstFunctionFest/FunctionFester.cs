using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FirstFunctionFest
{
    public class FunctionFester : IHttpFunction
    {
        /// <summary>
        /// Logic for your function goes here.
        /// </summary>
        /// <param name="context">The HTTP context, containing the request and the response.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            string name = context.Request.Query["name"].ToString();

            if (string.IsNullOrEmpty(name))
            {
                name = "Functions Festers";
            }

            await context.Response.WriteAsync($"Hello, {name}!");
        }
    }
}
