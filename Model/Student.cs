using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }

        [Required]
        public string Name { get; set; }
        [AllowNull]
        public string Major { get; set; }
    }
}
