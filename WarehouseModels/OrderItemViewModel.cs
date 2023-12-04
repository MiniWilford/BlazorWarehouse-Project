using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels
{
	public class OrderItemViewModel
	{
		public int OrderItemId { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public float Price { get; set; }
		public virtual ProductViewModel? Product { get; set; } = null; // ? = nullable, foreign key of Product
	}
}
