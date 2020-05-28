using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TradingBlockAPIHomeWork.Controllers
{
    public class StockController : Controller
    {
      
        private async Task<Stock> GetStock()
        {
            // Get an instance of HttpClient from the factpry that we registered
            // in Startup.cs
            var client = _httpClientFactory.CreateClient("API Client");

            // Call the API & wait for response. 
            // If the API call fails, call it again according to the re-try policy
            // specified in Startup.cs
            var result = await client.GetAsync("stable/stock/IBM/quote?token=Tpk_f7e3c0e925cd47ceba0e8c8590989b79");

            if (result.IsSuccessStatusCode)
            {
                // Read all of the response and deserialise it into an instace of
                // Stock class
                var content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Stock>(content);
            }
            return null;
        }

        public async Task<IActionResult> Index()
        {
            var model = await GetStock();
            // Pass the data into the View
            return View(model);
        }
    }
}
