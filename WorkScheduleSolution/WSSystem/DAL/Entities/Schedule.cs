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
        [Key, Column(Order = 1)]
        public int ShiftID { get; set; }

        [Key, Column(Order = 2)]
        public int EmployeeID { get; set; }

        public virtual Shift shift { get; set; }
        public virtual Employee employee { get; set; }
    }
}
