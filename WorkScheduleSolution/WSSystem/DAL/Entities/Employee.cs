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
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Firt name is required")]
        [StringLength(50,ErrorMessage = "First name must be within 50 characters long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last name is required")]
        [StringLength(50,ErrorMessage="Last name must be within 50 characters long")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression(@"^[1-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]", ErrorMessage="Phone number format is XXX.XXX.XXXX example-780.444.1212")]

        public string HomePhone { get; set; }
      
        public bool Active { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

        public Employee()
        {
            Active = true;
        }
    }
}
