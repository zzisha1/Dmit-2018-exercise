using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace WSSystem.DAL.Entities.POCOs
{
    public class EmployeeSkillDirectory
    {
       
        public string Skill { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Level { get; set; }
        public int? YOE { get; set; }
        
    }
}
