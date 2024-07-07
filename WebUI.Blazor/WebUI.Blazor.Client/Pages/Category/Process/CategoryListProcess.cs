using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using WebUI.Blazor.Client.ViewModel.Category;
using WebUI.Blazor.Client.ViewModel.Common;

namespace WebUI.Blazor.Client.Pages.Category.Process;

public class CategoryListProcess : ComponentBase
{
    [Inject] public HttpClient? Client { get; set; }

    protected ListResponseModel<ResultCategoryViewModel> Model = new();

    protected override async Task OnInitializedAsync()
    {
        await LoadList();
    }

    protected Task LoadList()
    {
        var serviceResponse =
            Client!.GetFromJsonAsync<ListResponseModel<ResultCategoryViewModel>>("https://localhost:7160/api/Category");

        if (serviceResponse.Result!.Success)
        {
            Model = serviceResponse.Result;
        }

        return Task.CompletedTask;
    }
}