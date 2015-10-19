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
    public class PlacementContract
    {
        [Key]
        public int PlacementContractID { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Key,Column(Order=1)]
        public int LocationID { get; set; }

        public virtual Location Locations { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
