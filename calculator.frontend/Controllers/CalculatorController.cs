﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace calculator.frontend.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        const string base_url = "https://calculatorbackend-mock.azurewebsites.net";
        const string api = "api/Calculator";
        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string operation)
        {
            double num1 = Convert.ToDouble(firstNumber);
            double num2 = Convert.ToDouble(secondNumber);
            var clientHandler = new HttpClientHandler();
            var client = new HttpClient(clientHandler);
            double result = 0;
            switch (operation)
            {
                case "Add":
                    operation = "Add";
                    var url = $"{base_url}/{api}/{operation}?a={num1}&b={num2}";
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(url),
                    };
                    using(var response = client.Send(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = response.Content.ReadAsStringAsync().Result;
                        var json = JObject.Parse(body);
                        var result_json = json["result"];
                        if (result_json != null)
                        {
                            result = result_json.Value<double>();
                        }
                    }
                    break;
                case "Subtract":
                    result = 0;
                    break;
                case "Multiply":
                    result = 0;
                    break;
                case "Divide":
                    result = 0;
                    break;
            }

            ViewBag.Result = result;
            return View();
        }
    }
}
