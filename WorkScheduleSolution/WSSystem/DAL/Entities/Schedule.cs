using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace WSSystem.DAL.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }

        [Required(ErrorMessage="Please enter the day of employeed schedule")]
        public DateTime Day { get; set; }
     
        [Required(ErrorMessage="Employee must be scheduled based on their shift")]
        public int ShiftID { get; set; }

        [Required(ErrorMessage = "Employee must be scheduled based on their ID")]
        public int EmployeeID { get; set; }

        public virtual Shift Shifts { get; set; }
        public virtual Employee Employees { get; set; }
    }
}
