namespace BlazorLesson1.Models
{
    public interface ICatalog
    {
        IReadOnlyList<Category> GetCategories();
    }
}