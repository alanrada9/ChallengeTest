namespace Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public long CompanyId { get; set; }

    }
}
