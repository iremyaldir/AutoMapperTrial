namespace AutoMapperTrial.Models
{
    public class UserInfoDTO
    {
        public string Name { get; set; }
        public string Status { get; set; }
    }
    public enum UserStatusEnum
    {
        Active = 0,
        Pending = 1,
        Passive = 2
    }
}
