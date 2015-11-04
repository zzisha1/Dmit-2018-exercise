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
         [DataObjectMethod(DataObjectMethodType.Select, false)]
         public List<Location> Location_List()
         {
             using (var context = new WorkSchedule())
             {
                 //retrieve the data from the specialEvent table
                 //to do so we will use the DBset in eRestaurantContext 
                 //call SoecialEvents (done by mapping)

                 //method syntax
                 //return context.SpecialEvents.OrderBy(x => x.Description).ToList();

                 //query syntax 
                 var results = from item in context.Locations
                               select item;
                 return results.ToList();

             }
         }



    }
}
