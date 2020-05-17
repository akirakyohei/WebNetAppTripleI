using System;
using System.Collections.Generic;

namespace ProjectOp.DTO
{
    public class UserDTO
    {
        public UserDTO()
        {
        }
        public int id { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
        public string quote { get; set; }
        public string department { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public List<AchievementDTO> achievements { get; set; }
    }
}
