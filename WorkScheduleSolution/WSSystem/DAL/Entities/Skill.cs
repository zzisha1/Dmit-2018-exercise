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
        [Required(ErrorMessage="Please enter description of skills")]
        [StringLength(100)]
        public string Description { get; set; }
        
        public bool RequiredTicket { get; set; }

        public virtual ICollection<EmployeeSkill>EmployeeSkills { get; set; }

    }
}
