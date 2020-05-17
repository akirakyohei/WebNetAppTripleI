using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectOp.Entities
{
    public class User
    {
        public User()
        {
        }
        [Key]
        public int UserID { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
        public string quote { get; set; }
        public string department { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public List<Achievement> achievements { get; set; }
    }
}
