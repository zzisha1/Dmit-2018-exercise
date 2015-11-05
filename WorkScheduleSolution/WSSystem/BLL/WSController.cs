using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using WSSystem.DAL.Entities;
using WSSystem.DAL;
using System.ComponentModel;
//using WSSystem.DAL.Entities.DTOs;
using WSSystem.DAL.Entities.POCOs; //used for ODS access
#endregion

namespace WSSystem.BLL
{
    [DataObject]
    public class WSController
    {
        #region ListView for CRUD

        [DataObjectMethod(DataObjectMethodType.Select, false)]
         public List<Location> Location_List()
         {
             using (WorkSchedule context = new WorkSchedule())
             {
                var results = from item in context.Locations
                              orderby item.Name
                               select item;
                 return results.ToList();
             }
         }

        #endregion

        #region CRUD Insert, Update 
        [DataObjectMethod(DataObjectMethodType.Insert, false)] //let the user slect to slelect method
        public void Location_Add(Location item)
        {
            //input into this method at the instance level
            using (WorkSchedule context = new WorkSchedule())
            {
                //create a pointer variable for the instance type
                //set this pointer to null
                Location added = null;
                //setup the add request for the dbcontext
                added = context.Locations.Add(item);

                //saving the changes will cause the .Add to execute

                //commits the Add to database
                //evaluates the annotation (validation) on your entity
                context.SaveChanges();



            }


        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Location_Update(Location item)
        {
            using (WorkSchedule context = new WorkSchedule())
            {
                context.Entry<Location>(context.Locations.Attach(item)).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }

        #endregion


    }
}
