namespace BlazorLesson1.Models
{
    public interface IProductsCatalog
    {
        IReadOnlyList<Product> GetProducts();
        //Task<List<Product>> GetProductsAsync();
        //Task<Product> GetProductAsync(string productName);
        //Task AddProductsAsync(Product product);
        //Task<bool> RemoveProductsAsync(Product product);
    }
}
