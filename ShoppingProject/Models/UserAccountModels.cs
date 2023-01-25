namespace ShoppingProject.Models
{
    public class UserAccountModels: BaseModel
    {
        public int RoleId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
