using System;
using System.Collections.Generic;

namespace EFWork.Models
{
    public partial class Document
    {
        public Document()
        {
            Employees = new HashSet<Employee>();
        }

        public int DocumentsPackId { get; set; }
        public int? PasportId { get; set; }
        public int? EmploementHistory { get; set; }
        public int? MedicalBook { get; set; }
        public int? Snils { get; set; }
        public int? ControlListId { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
