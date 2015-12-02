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

        [Required(ErrorMessage="Name is required")]
        [StringLength(50, ErrorMessage = " Name must be within 50 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Street name is required")]
        [StringLength(50, ErrorMessage = "Street must be within 50 characters long")]
        public string Street { get; set; }
      
        [Required(ErrorMessage="City name is required")]
        [StringLength(30, ErrorMessage = "City must be within 30 characters long")]
        public string City { get; set; }

        [Required(ErrorMessage="Province name is required")]
        [StringLength(2, ErrorMessage="Province must be 2 characters long")]
        public string Province { get; set; }

        [StringLength(50, ErrorMessage="Contact must be within 50 characters")]
        public string Contact { get; set; }

        [Required(ErrorMessage="Phone number is required")]

        [RegularExpression(@"^[1-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]", ErrorMessage = "Phone number format is XXX.XXX.XXXX Example-780.444.1212")]

        public string Phone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PlacementContract> PlacementContracts { get; set; }

        public Location()
        {
            Active = true;
        }
    }
}
