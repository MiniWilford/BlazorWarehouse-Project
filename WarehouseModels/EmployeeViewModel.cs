﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels 
{
	public class EmployeeViewModel 
	{
		public int EmployeeId { get; set; }
		[MaxLength(50)]
		public string? FirstName { get; set; }
		[MaxLength(50)]
		public string? LastName { get; set; }

        public int ManagerId { get; set; }
		public virtual ManagerViewModel? Manager { get; set; } = null;
	}
}
