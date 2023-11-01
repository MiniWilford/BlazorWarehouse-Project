using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClassLibraryMVC.Entities
{
    [Table("Schedules")]
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>(); // FK Employee
    }
}
