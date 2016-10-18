namespace Assignment02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CricketInfoMain")]
    public partial class CricketInfoMain
    {
        [Key]
        public int GameID { get; set; }

        [Required]
        public string Team_1_Name { get; set; }

        [Required]
        public string Team_2_Name { get; set; }

        public int Team_1_Runs { get; set; }

        public int Team_2_Runs { get; set; }

        public int Team_1_Outs { get; set; }

        public int Team_2_Outs { get; set; }

        public int Spectators { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEntered { get; set; }
    }
}
