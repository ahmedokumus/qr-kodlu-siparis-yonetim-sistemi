namespace WebUI.Blazor.Client.ViewModel.Common;

public class ListResponseModel<T> : ResponseModel
{
    public List<T>? Data { get; set; }
}