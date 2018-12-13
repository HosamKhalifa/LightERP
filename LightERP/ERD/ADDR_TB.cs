namespace LightERP.ERD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADDR_TB")]
    public partial class AddressBase:LineBase
    {
     

        public int ROW_NUM { get; set; }

        public bool IS_PRIMARY { get; set; }

        [StringLength(300)]
        public string ADDRESS { get; set; }

        [StringLength(150)]
        public string CONTACT { get; set; }

        [StringLength(150)]
        public string RPT_HINT { get; set; }

        [StringLength(30)]
        public string TEL { get; set; }

        [StringLength(30)]
        public string MOB { get; set; }

        [StringLength(30)]
        public string FAX { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(3)]
        public string COUNTRY { get; set; }

        [StringLength(4)]
        public string CITY { get; set; }

        [StringLength(20)]
        public string TAX_FILE_NUM { get; set; }

        [StringLength(20)]
        public string TAX_CARD_NUM { get; set; }

        [StringLength(20)]
        public string COMM_REGISTER_NUM { get; set; }

        public long? TAX_AGENCY_ID { get; set; }

        public long? VAT_GROUP_LID { get; set; }

        public virtual LineBase LINE_BASE { get; set; }
    }
}
