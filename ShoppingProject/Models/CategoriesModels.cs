namespace ShoppingProject.Models
{
    public class CategoriesModels: FullBaseModel
    {
        public string CategoryName { get; set; }
        public ICollection<CategoriesImages> CategoriesImages { get; set; }
        public ICollection<SubCategoriesModels> SubCategoriesModels { get; set; }
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

    public class SubCategoriesModels : FullBaseModel
    {
        public int CategoryId { get; set; }
        public virtual CategoriesModels CategoriesAccount { get; set; } 
        public string SubCategoryName { get; set; }
        public ICollection<SubCategoriesImages> SubCategoriesImages { get; set; }
    }
    public class SubCategoriesImages
    {
        public int Id { get; set; }
        public virtual SubCategoriesModels CateogryAccount { get; set; }
        public int SubCategoryId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string DisplayName { get; set; }
    }
}
