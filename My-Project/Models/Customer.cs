using System.ComponentModel.DataAnnotations;

namespace My_Project.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateOnly OrderDate { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }
        public string OrderDetails { get; set; }

    }
}
