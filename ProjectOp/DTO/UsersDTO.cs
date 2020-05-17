using System;
namespace ProjectOp.DTO
{
    public class UsersDTO
    {
        public UsersDTO(int id, string name, string nationality, string quote, string department, string image1, string image2)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.quote = quote;
            this.nationality = nationality;
            this.image1 = image1;
            this.image2 = image2;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
        public string quote { get; set; }
        public string department { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
    }
}
