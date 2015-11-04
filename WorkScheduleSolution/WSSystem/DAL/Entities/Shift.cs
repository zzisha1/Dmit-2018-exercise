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

        [Required(ErrorMessage="Every Contract mmust be placed")]
        public int PlacementContractID { get; set; }

        [Required(ErrorMessage="Please enter day of week")]
        public int DayofWeek { get; set; }

        [Required(ErrorMessage="Please set the starting time")]
        public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "Please set the finishing time")]
        public TimeSpan EndTime { get; set; }

        [Required(ErrorMessage = "Please enter the number of employees")]
        public int NumberofEmployees { get; set; }

        [Required(ErrorMessage = "Please choose if the employee is active or not")]
        public bool Active { get; set; }
        
        [StringLength(100, ErrorMessage="Notes must be within 100 characters")]
        public string Notes { get; set; }

        public virtual PlacementContract PlacementContracts { get; set; }
        public virtual ICollection<Schedule>Schedules { get; set; }

        public Shift()
        {
            Active = true;
        }

    }
}
