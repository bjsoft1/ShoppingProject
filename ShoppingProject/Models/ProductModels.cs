//namespace ShoppingProject.Models
//{
//    public class ProductModels:FullBaseModel
//    {
//        public string ProductName { get; set; }
//        public string ProductDescription { get; set; }
//        public string ProductPrice { get; set; }
//        public string DiscountOffer { get; set; }
//        public virtual ICollection<ProductImages> ProductImages { get; set; }
//        public virtual ICollection<ProductReviews> ProductReviews { get; set; }
//    }

//    public class ProductImages
//    {
//        public int Id { get; set; }
//        public virtual ProductModels ProductModel { get; set; }
//        public int ProductId { get; set; }
//        public string ImageName { get; set; }
//        public string ImagePath { get; set; }
//        public string DisplayName { get; set; }
//    }

//    public class ProductReviews: FullBaseModel
//    {
//        public virtual ProductModels ProductModel { get; set; }
//        public int ProductId { get; set; }
//        public string ReviewComment { get; set; }
//        public int Rating { get; set; }
//    }
//}
