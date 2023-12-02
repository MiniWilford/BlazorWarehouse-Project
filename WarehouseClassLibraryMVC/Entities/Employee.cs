using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClassLibraryMVC.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        public int ManagerId { get; set; }
        public virtual Manager? Manager { get; set; } = null;
    }
}
