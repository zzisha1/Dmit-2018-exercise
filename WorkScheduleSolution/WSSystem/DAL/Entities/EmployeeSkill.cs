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
    public class EmployeeSkill
    {   
        public enum SkillLevel
        {
             Novice,
             Proficent,
             Expert
        }

        [Key]
        public int EmployeeSkillID { get; set; }
        [Required(ErrorMessage = "Please enter employee id")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage="Please enter skill id")]
        public int SkillID { get; set; }

        [Required(ErrorMessage="Please enter level of employee skills")]
        public SkillLevel Level { get; set; }
        public int? YearsOfExperience { get; set;}

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }           

    }
}
