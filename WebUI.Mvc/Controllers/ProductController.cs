using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebUI.Mvc.ViewModels.CategoryViewModels;
using WebUI.Mvc.ViewModels.ProductViewModels;
using WebUI.Mvc.ViewModels.Common;

namespace WebUI.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ProductList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7160/api/Product/WithCategories");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ListResponseModel<ResultProductsWithCategoriesViewModel>>(jsonData);
                return View(result);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel create)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(create);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7160/api/Product", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("ProductList");
            }
            return NotFound();
        }

        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7160/api/Product/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("ProductList");
            }
            return NotFound();
        }

        public async Task<IActionResult> GetUpdateProduct(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7160/api/Product/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                return Content(jsonData, "application/json");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductViewModel update)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(update);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7160/api/Product", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("ProductList");
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<JsonResult> GetCategories()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7160/api/Category");
            if (!response.IsSuccessStatusCode)
            {
                return Json(new { success = false, message = "Error fetching categories" });
            }

            var jsonData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ListResponseModel<ProductDropdownCategoriesViewModel>>(jsonData);
            return Json(result);
        }
    }
}
