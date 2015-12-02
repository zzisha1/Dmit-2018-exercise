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
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }

       
        [Required(ErrorMessage="Description is required")]
        [StringLength(100,ErrorMessage="Description must be within 100 characters long")]
        public string Description { get; set; }

        [Required(ErrorMessage="Please choose required ticket on or off")]
        public bool RequiredTicket { get; set; }

        public virtual ICollection<EmployeeSkill>EmployeeSkills { get; set; }

    }
}
