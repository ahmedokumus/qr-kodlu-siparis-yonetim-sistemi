namespace WebUI.Mvc.ViewModels.ProductViewModels;

public class UpdateProductViewModel
{
    public UpdateProductViewModel(Guid id, Guid categoryId, string productName, string productDescription, decimal productPrice, string productImageUrl, bool status)
    {
        Id = id;
        CategoryId = categoryId;
        ProductName = productName;
        ProductDescription = productDescription;
        ProductPrice = productPrice;
        ProductImageUrl = productImageUrl;
        Status = status;
    }

    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImageUrl { get; set; }
    public bool Status { get; set; }
}