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
        [Key]
        public int EmployeeSkillID { get; set; }

        [Key, Column(Order=1)]
        public int EmployeeID { get; set; }
        [Key, Column(Order=2)]
        public int SkillID { get; set; }

        [Required]
        public int Level { get; set; }
        public int? YearsOfExperience { get; set;}


        public virtual Employee employee { get; set; }
        public virtual Skill skill { get; set; }

    }
}
