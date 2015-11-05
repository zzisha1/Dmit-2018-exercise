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

        [Required(AllowEmptyStrings = false), StringLength(50)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false), StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        [RegularExpression(@"^[1-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]")]

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
