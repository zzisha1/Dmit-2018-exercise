using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
#endregion

namespace WSSystem.DAL.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        public int PlacementContractID { get; set; }
        public int DayofWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int NumberofEmployees { get; set; }
        public bool Active { get; set; }
        
        [StringLength(100)]
        public string Notes { get; set; }

        public virtual PlacementContract PlacementContracts { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

    }
}
