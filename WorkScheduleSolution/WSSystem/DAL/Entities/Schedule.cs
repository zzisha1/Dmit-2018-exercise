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
    class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }

        public DateTime Day { get; set; }
     
        public int ShiftID { get; set; }

     
        public int EmployeeID { get; set; }

        public virtual Shift Shifts { get; set; }
        public virtual Employee Employees { get; set; }
    }
}
