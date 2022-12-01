namespace Vedmak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListInfo")]
    public partial class ListInfo
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonageID { get; set; }

        [StringLength(50)]
        public string Title1 { get; set; }

        public string Subscrib1 { get; set; }

        [StringLength(50)]
        public string Title2 { get; set; }

        public string Subscrib2 { get; set; }

        [StringLength(50)]
        public string Title3 { get; set; }

        public string Subscribe3 { get; set; }

        [StringLength(50)]
        public string Title4 { get; set; }

        public string Subscribe4 { get; set; }
    }
}
