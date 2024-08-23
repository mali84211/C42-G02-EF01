using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01
{
    //By Convention
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Salary { get; set; }
    //    public int? Age { get; set; }
    //    public string Address { get; set; }
    //}

    //Data Annotation
    //[Table("Employee",Schema ="dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }
    //    [Required]
    //    [Column(TypeName="varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50,MinimumLength =10, ErrorMessage ="")]
    //    public string Name { get; set; }
    //    [Column(TypeName = "money")]
    //    public double Salary { get; set; }
    //    [Required]
    //    [Range(20,60)]
    //    public int? Age { get; set; }
    //    public string Address { get; set; }
    //    [Phone]
    //    public string Phone { get; set; }
    //    [EmailAddress]
    //    public string Email { get; set; }
    //    [NotMapped]
    //    public double TotalSalary { get; set; }
    //}

    //Fluent API
 
    internal class Employee
    {
       
        public int EmpId { get; set; }
       
        public string Name { get; set; }
        
        public double Salary { get; set; }
        
        public int? Age { get; set; }
        public string Address { get; set; }
       
        public string Phone { get; set; }
       
        public string Email { get; set; }
  
        public double TotalSalary { get; set; }
    }
}
