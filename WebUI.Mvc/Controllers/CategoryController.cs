using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Mvc.ViewModels.CategoryViewModels;
using WebUI.Mvc.ViewModels.Common;

namespace WebUI.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CategoryList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7160/api/Category");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ListResponseModel<ResultCategoryViewModel>>(jsonData);
                return View(result);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryViewModel create)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(create);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7160/api/Category", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("CategoryList");
            }
            return NotFound();
        }

        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7160/api/Category/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("CategoryList");
            }
            return NotFound();
        }
        
        public async Task<IActionResult> UpdateCategoryGet(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7160/api/Category/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                return Content(jsonData, "application/json");  // Return JSON response directly
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryViewModel update)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(update);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7160/api/Category", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("CategoryList");
            }
            return NotFound();
        }
    }
}
