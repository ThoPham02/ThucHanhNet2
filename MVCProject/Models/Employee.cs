using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models {
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmplID { get; set; }
        public String EmplName { get; set; }
    }
}