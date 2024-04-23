using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.CodeAnalysis.Options;

namespace Lab1_EntityFramework.Models
{
    public class leave
    {
        [Key]
        [DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        public int LeaveId { get; set; }
        
        [DisplayName("Startdatum")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Slutdatum")]
        public DateTime? EndDate { get; set; }
        [DisplayName("Ansökningsdatum")]
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        
        [DisplayName("Employee")]
        [ForeignKey("Employee")]
        public int FK_EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        [DisplayName("Frånvarotyp")]

        [ForeignKey("LeaveType")]
        public int FK_LeaveTypeId { get; set; }
        public LeaveType? leaveTypes { get; set; }
    }
}
