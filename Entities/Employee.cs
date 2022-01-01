using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationExample.Entities
{
    [Keyless]
    [Table("Employee")]
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? EmployeeName { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Department { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfJoining { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? PhotoFileName { get; set; }
        
        [StringLength(500)]
        [JsonIgnore]
        public string? Password { get; set; }
        
    }
}
