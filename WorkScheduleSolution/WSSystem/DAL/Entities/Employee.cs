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

        [Required(ErrorMessage="Please Enter First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

         [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
     
        [RegularExpression(@"^[1-9][0-9][0-9]\.[0-9]\d{3}\.[0-9]\d{4}")]
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
