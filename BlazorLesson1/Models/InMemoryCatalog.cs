namespace BlazorLesson1.Models
{
    public class InMemoryCatalog : ICatalog
    {
        private readonly List<Category> _categories = new()
        {
            new (1, "Продукты"),
            new (2,"Косметика"),
        };

        public IReadOnlyList<Category> GetCategories()
        {
            return _categories.AsReadOnly();
        }
    }
}
