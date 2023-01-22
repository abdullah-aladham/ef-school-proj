using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    public class Teacher
    {
        [Key] public int Teacher_Id { get; set; }
        [Required] public string Name { get;set; }
        [Required] public string Major { get;set; }
        [Required] public string phoneNumber { get;set; }
    }
}
