namespace LightERP.ERD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LINE_BASE")]
    public partial class LineBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LineBase()
        {
            LINE_BASE1 = new HashSet<LineBase>();
        }

        [Key,Column("LINE_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LineId { get; set; }
        [Column("CREATED_BY")]
        public int CreatedBy { get; set; }
        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
        [Column("MODIFIED_BY")]
        public int ModifiedBy { get; set; }
        [Column("MODIFIED_AT")]
        public DateTime ModifiedAt { get; set; }
        [Column("TABLE_ID")]
        public int TableId { get; set; }
        [Column("COMP_ID")]
        public int CompanyId { get; set; }
        [Column("PARENT_LINE")]
        public long? ParentLine { get; set; }
        [Column("LUID")]
        public long? LocalUID { get; set; }

        [StringLength(7)]
        public string OLD_REF { get; set; }
        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineBase> LINE_BASE1 { get; set; }

        public virtual LineBase LINE_BASE2 { get; set; }
    }
}
