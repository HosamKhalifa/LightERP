namespace LightERP.ERD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOUR.CUST_ACT_TB")]
    public partial class CUST_ACT_TB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LINE_ID { get; set; }

        public long? AR_AID { get; set; }

        public long? SAL_PERSON_AID { get; set; }

        public decimal? CREDIT_LIMIT { get; set; }
    }
}
