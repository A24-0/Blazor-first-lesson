namespace BlazorLesson1.Models
{
    public class Product
    {
        public Product(string name, decimal price, string imageUrl)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException($"'{nameof(name)}' не может быть нулевым или пустым.", nameof(name));
            }
            if (price < 0)
            {
                throw new ArgumentNullException(nameof(price));
            }
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

    }
}
