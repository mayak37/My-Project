using System.ComponentModel.DataAnnotations;

namespace My_Project.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateOnly CreateDate { get; set; }

    }
}
