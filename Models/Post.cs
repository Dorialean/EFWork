using System;
using System.Collections.Generic;

namespace EFWork.Models
{
    public partial class Post
    {
        public Post()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public decimal? Salary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
