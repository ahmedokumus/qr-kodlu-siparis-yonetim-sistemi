using WebUI.Mvc.ViewModels.Common;

namespace WebUI.Mvc.ViewModels.ProductViewModels;

public class ResultProductsWithCategoriesViewModel : BaseViewModel
{
    public ResultProductsWithCategoriesViewModel(string productName, string categoryName, string productDescription, decimal productPrice, string productImageUrl, bool status)
    {
        ProductName = productName;
        CategoryName = categoryName;
        ProductDescription = productDescription;
        ProductPrice = productPrice;
        ProductImageUrl = productImageUrl;
        Status = status;
    }

    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImageUrl { get; set; }
    public bool Status { get; set; }
}