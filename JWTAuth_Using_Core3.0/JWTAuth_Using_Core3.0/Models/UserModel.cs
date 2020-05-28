namespace JWTAuth_Using_Core3._0.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }        
        public string RoleName { get; set; }
        public UserRole UserRole { get; set; }
    }
}
