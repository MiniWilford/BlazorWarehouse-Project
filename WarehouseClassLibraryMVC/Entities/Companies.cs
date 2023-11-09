using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseClassLibraryMVC.Entities
{
    [Table("Companies")]
    public class Companies
    {
        public int CompanyId { get; set; }
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [DisplayName("Zip Code")]
        public string? PostalCode { get; set; }

        //Navigational Property
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // Virtual helps performance, Order Foreign Key
    }
}
