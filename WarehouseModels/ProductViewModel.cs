using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels
{
	public class ProductViewModel
	{
		public int ProductId { get; set; }
		[MaxLength(50)]
		public string? ProductName { get; set; }
		public float ProductPrice { get; set; }
	}
}
