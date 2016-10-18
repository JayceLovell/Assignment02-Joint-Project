namespace Assignment02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team1
    {
        [Key]
        [Column(Order = 0)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TEAMNAME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal TEAMSCORE { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal BATSMANOUT { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal SPECTATORS { get; set; }
    }
}
