namespace Assignment02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team2
    {
        [Key]
        public int GameID { get; set; }

        [Required]
        [StringLength(50)]
        public string TEAMNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TEAMSCORE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BATSMANOUT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SPECTATORS { get; set; }
    }
}
