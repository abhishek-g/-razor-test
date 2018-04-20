using System.ComponentModel.DataAnnotations;

namespace Data {
    public class Customer 
    {
        public int Id { get; set; }        

        [Required , StringLength(10)]
        public string Fullname { get; set; }
    }
}