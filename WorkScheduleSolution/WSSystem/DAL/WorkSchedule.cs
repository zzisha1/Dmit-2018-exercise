using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using WSSystem.DAL.Entities;
#endregion

namespace WSSystem.DAL
{
    internal class WorkSchedule : DbContext
    {
        public WorkSchedule(): base("name=WSdb")
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Shift> Shifts {get;set;}
        public DbSet<PlacementContract> PlacementContracts { get; set; }
        public DbSet<Skill> Skills { get; set; }

        
        
    }
}
