using BlazorLesson1.Models;
using System.Threading;

namespace BlazorLesson1.Models
{
    public class InMemoryProductsCatalog: IProductsCatalog
    {
        private readonly List<Product> _products = new()
        {
            new("Book-1", 700m, "image/1.jpg"),
            new("Book-2", 900m, "image/2.jpg"),
            new("Book-3",  200m, "image/3.jpg")
        };

        public IReadOnlyList<Product> GetProducts()
        {
            return _products.AsReadOnly();
        }
    }
}