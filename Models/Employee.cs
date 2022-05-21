using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFWork.Models
{
    public partial class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableNumberId { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public int Age { get; set; }
        public string SizeOfClothes { get; set; } = null!;
        public DateTime? DateOfPromotion { get; set; }
        public int? DocumentsPackId { get; set; }
        public int? PostId { get; set; }

        public virtual Document? DocumentsPack { get; set; }
        public virtual Post? Post { get; set; }
    }
}
