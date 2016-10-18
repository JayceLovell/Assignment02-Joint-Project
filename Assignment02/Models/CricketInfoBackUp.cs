namespace Assignment02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CricketInfoBackUp")]
    public partial class CricketInfoBackUp
    {
        [Key]
        [Column(Order = 0)]
        public int GameID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Team_1_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Team_2_Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team_1_Runs { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team_2_Runs { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team_1_Outs { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team_2_Outs { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Spectators { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "date")]
        public DateTime DateEntered { get; set; }
    }
}
