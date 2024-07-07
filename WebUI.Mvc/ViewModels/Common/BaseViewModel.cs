namespace WebUI.Mvc.ViewModels.Common;

public class BaseViewModel
{
	public Guid Id { get; set; }
	public DateTime CreatedDate { get; set; }
	public DateTime? UpdatedDate { get; set; }
	//public DateTime? DeletedDate { get; set; }
}