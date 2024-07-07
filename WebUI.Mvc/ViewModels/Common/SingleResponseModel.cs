namespace WebUI.Mvc.ViewModels.Common;

public class SingleResponseModel<T> : ResponseModel
{
	public T? Data { get; set; }
}