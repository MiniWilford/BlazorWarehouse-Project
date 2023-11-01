using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseClassLibraryMVC.Entities
{
    [Table("Orders")]
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } = null; // ? = nullable
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // Virtual to make "lazy", OrderItem FK
    }
}
