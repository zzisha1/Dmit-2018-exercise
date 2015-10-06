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
        public int SkillID { get; set; }
        public string Description { get; set; }
        public bool RequiredTicket { get; set; }
    }
}
