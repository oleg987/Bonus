﻿namespace Bonus.Models
{
    public class ShitCoin
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
