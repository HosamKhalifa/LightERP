namespace LightERP.ERD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOUR.ACT_REFNO1_TB")]
    public partial class ACT_REFNO1_TB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LINE_ID { get; set; }

        public int ACT_TABLE_ID { get; set; }
    }
}
