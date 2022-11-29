namespace Vedmak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personage")]
    public partial class Personage
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? ChapterID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Subscribe { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string Race { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string Occupation { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string Affination { get; set; }

        [StringLength(25)]
        public string Alive { get; set; }

        public string PictureURL { get; set; }

        public virtual Chapter Chapter { get; set; }
    }
}
