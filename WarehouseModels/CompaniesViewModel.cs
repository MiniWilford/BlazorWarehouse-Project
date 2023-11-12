using System.ComponentModel;

namespace WarehouseModels
{
    public class CompaniesViewModel
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