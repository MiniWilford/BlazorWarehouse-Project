using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels
{
    public class CompanyViewModel
    {
        public int CompanyId { get; set; }
        [MaxLength(50)]
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
		[MaxLength(50)]
		public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
    }
}