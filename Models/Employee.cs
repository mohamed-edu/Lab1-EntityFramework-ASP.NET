using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_EntityFramework.Models
{
    public class Employee
    {
         
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [DisplayName("Förnamn")]
        public string? FirstName { get; set; }
        [DisplayName("Efternamn")]
        public string? LastName { get; set; }
        [DisplayName("Födelsedatum")]
        public DateTime BirthDate { get; set; }

        public ICollection<leave>? Vacations { get; set; }
    }
}
