namespace LightERP.ERD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACT_TB")]
    public partial class AccountBase:LineBase
    {
       

        [Required]
        [Column("DISPLAY_NUMBER"),StringLength(9)]
        public string  DisplayNumber { get; set; }

        [Required]
        [Column("NAME"),StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Column("DESCRIPTION"),StringLength(250)]
        public string Description { get; set; }
        [Column("ACTIVE")]
        public bool Active { get; set; }
        [Column("REF_NO1")]
        public long? ReferenceNumberOne { get; set; }
        [Column("REF_NO2")]
        public long? ReferenceNumberTwo { get; set; }
        [Column("GROUP_ID")]
        public long? GroupId { get; set; }

        [Column("REF_NUM"),StringLength(30)]
        public string ReferenceNumber { get; set; }

        [Column("DIM_VAL"),StringLength(9)]
        public string DimensionValue { get; set; }

        
    }
}
