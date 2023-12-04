using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarehouseClassLibraryMVC.Entities
{
    [Table("Companies")]
    public class Company
    {
        public int CompanyId { get; set; }
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [DisplayName("Zip Code")]
        public string? PostalCode { get; set; }

    }
}
