namespace WebUI.Blazor.Client.ViewModel.Common;

public class SingleResponseModel<T> : ResponseModel
{
    public T? Data { get; set; }
}