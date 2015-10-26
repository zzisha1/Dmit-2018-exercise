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
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required(ErrorMessage = "A Name is required maximum 50 characters)")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage="Street is required")]
        [StringLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage="Please enter the city")]
        [StringLength(30)]
        public string City { get; set; }

        [Required(ErrorMessage="Please enter Province")]
        [StringLength(2, ErrorMessage="Province must be 2 characters long")]
        public string Province { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [Required(ErrorMessage="Please enter phone number")]
      
    
        [RegularExpression(@"^[1-9][0-9][0-9]\.[0-9]\d{3}\.[0-9]\d{4}")]

        public string Phone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PlacementContract> PlacementContracts { get; set; }

        public Location()
        {
            Active = true;
        }
    }
}
