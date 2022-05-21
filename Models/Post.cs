using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFWork.Models
{
    public partial class Post
    {
        public Post()
        {
            Employees = new HashSet<Employee>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public decimal? Salary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
