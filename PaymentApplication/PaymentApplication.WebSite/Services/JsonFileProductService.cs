using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PaymentApplication.WebSite.Models;
using Microsoft.AspNetCore.Hosting;

namespace PaymentApplication.WebSite.Services
{
    public class JsonFileProductService
    {
        public string FirstName { get; set; }
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        public IEnumerable<UserPayment> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<UserPayment[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void SubmitName(string userPayment)
        {
            var test = userPayment;

        }
    }

}