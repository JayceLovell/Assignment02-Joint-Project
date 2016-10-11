namespace Assignment02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool EntryLevel { get; set; }

        [Column("D.O.B", TypeName = "date")]
        public DateTime D_O_B { get; set; }

        [Column(TypeName = "date")]
        public DateTime Registerdate { get; set; }
    }
}
