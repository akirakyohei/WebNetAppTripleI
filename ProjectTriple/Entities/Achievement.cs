using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectOp.Entities
{
    public class Achievement
    {
        public Achievement()
        {
        }
        [Key]
        public int AchievementID { get; }
        public string achieve { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
