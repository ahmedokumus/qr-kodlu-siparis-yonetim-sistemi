namespace WebUI.Mvc.ViewModels.Common;

public class ListResponseModel<T> : ResponseModel
{
	public List<T>? Data { get; set; }
}