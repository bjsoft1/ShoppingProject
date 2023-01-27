namespace ShoppingProject.Models
{
    public class CategoriesModels: FullBaseModel
    {
        public string CategoryName { get; set; }
        public ICollection<CategoriesImages> CategoriesImages { get; set; }
    }
    public class CategoriesImages
    {
        public int Id { get; set; }
        public virtual CategoriesModels CateogryAccount { get; set; }
        public int CategoryId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string DisplayName { get; set; }
    }
}
