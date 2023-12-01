using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels {
	public class OrderViewModel {
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public int CompanyId { get; set; }
	}
}
