using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationExample.Entities
{
    [Keyless]
    [Table("Department")]
    public partial class Department
    {
        public int DepartmentId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? DepartmentName { get; set; }
    }
}
