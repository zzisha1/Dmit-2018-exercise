﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
#endregion


namespace WSSystem.DAL.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Street { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        [StringLength(2, ErrorMessage="Province must be 2 characters")]
        public string Province { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength (12)]
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}
