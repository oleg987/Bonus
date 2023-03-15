namespace Bonus.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long Bonus { get; set; }
        public long EyeLength { get; set; }
        public IComparable<ShitCoin> Coins { get; set; }
    }
}
