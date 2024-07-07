namespace WebUI.Mvc.ViewModels.ProductViewModels;

public class CreateProductViewModel
{
    public CreateProductViewModel(string productName, string productDescription, decimal productPrice, string productImageUrl, bool status, Guid categoryId)
    {
        ProductName = productName;
        ProductDescription = productDescription;
        ProductPrice = productPrice;
        ProductImageUrl = productImageUrl;
        Status = status;
        CategoryId = categoryId;
    }

    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImageUrl { get; set; }
    public bool Status { get; set; }
    public Guid CategoryId { get; set; }
}