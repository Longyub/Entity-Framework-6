namespace Entity_Framework_6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Object1
    {
        [Key]
        [StringLength(20)]
        public string EmpId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
